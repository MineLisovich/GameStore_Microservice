using Microservice.Products.Data;
using Microservice.Products.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.Bind("ConnectionString", new Config());
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<AuthOption>();
builder.Services.AddDbContext<ProductsDbContext>(x => x.UseSqlServer(Config.DefaultConnection));
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
            ValidIssuer = AuthOption.ISSUER,

            //����� �� �������������� ����������� ������
            ValidateAudience = true,
            //��������� ����������� ������
            ValidAudience = AuthOption.AUDIENCE,

            //����� �� �������������� ����� ������������� ������
            ValidateLifetime = true,

            //��������� ���������� �����
            IssuerSigningKey = AuthOption.GetSymmetricSecurityKey(),
            //��������� ���������� �����
            ValidateIssuerSigningKey = true,
        };
    });
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    HttpOnly = HttpOnlyPolicy.Always,
    Secure = CookieSecurePolicy.Always
});

app.UseHttpsRedirection();
app.UseCors("AllowAll");
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

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();