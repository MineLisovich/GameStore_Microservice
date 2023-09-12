using Microservice.GameStore.Data;
using Microservice.GameStore.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration.GetValue<string>("DbConnection");
builder.Services.AddDbContext<AuthDbContext>(x => x.UseSqlServer(configuration));
builder.Services.AddTransient<AuthOptions>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(conf =>
{
    //������ ������
    conf.Password.RequiredLength = 4;
    //���������� � ������
    conf.Password.RequireDigit = false;
    //���������� � ���� ��������
    conf.Password.RequireNonAlphanumeric = false;
    //���������� � ��������� ������
    conf.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<AuthDbContext>().AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(conf =>
{
    conf.Cookie.Name = "GemeStoreCookie";
    conf.LoginPath = "/Account/Login";
    conf.LogoutPath = "/Account/Logout";
    conf.ExpireTimeSpan = TimeSpan.FromMinutes(120);
});

builder.Services.AddCors(conf =>
{
    conf.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
    option =>
    {

        option.RequireHttpsMetadata = false; // �����  ���� ����� false, �� SSL ��� �������� ������ �� ������������. ������ ������ ������� ���������� ������ �� ������������. � �������� ���������� ��� �� ����� ������������ �������� ������ �� ��������� https.
        option.SaveToken = true;
        option.TokenValidationParameters = new TokenValidationParameters
        {
            //���������, ����� �� �������������� ��������� ��� ��������� ������
            ValidateIssuer = true,
            //������ �������������� ��������
            ValidIssuer = AuthOptions.ISSUER,

            //����� �� �������������� ����������� ������
            ValidateAudience = true,
            //��������� ����������� ������
            ValidAudience = AuthOptions.AUDIENCE,

            //����� �� �������������� ����� ������������� ������
            ValidateLifetime = true,

            //��������� ���������� �����
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            //��������� ���������� �����
            ValidateIssuerSigningKey = true,
        };
    });

builder.Services.AddAuthorization(conf =>
{
    conf.AddPolicy("AdminArea", policy =>
    {
        policy.RequireRole(UserRolesList.Admin);
    });
    conf.AddPolicy("UserArea", policy =>
    {
        policy.RequireRole(UserRolesList.User);
    });
});

builder.Services.AddControllersWithViews(conf =>
{
    conf.Conventions.Add(new AdminAreaAuthorization(UserRolesList.Admin, "AdminArea"));
    conf.Conventions.Add(new UserAreaAuthorization(UserRolesList.User, "UserArea"));
}).AddSessionStateTempDataProvider();

//
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("AllowAll");
app.UseRouting();

app.Use(async (context, next) =>
{
    var token = context.Request.Cookies["GemeStoreCookie"];
    if (!string.IsNullOrEmpty(token))
        context.Request.Headers.Add("Authorization", "Bearer " + token);
    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
    context.Response.Headers.Add("X-Xss-Protection", "1");
    context.Response.Headers.Add("X-Frame-Options", "DENY");
    await next();
});

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "Admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "User",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
