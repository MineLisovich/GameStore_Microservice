

using Microservice.Authorization.Data;
using Microservice.Authorization.Data.Repositories;
using Microservice.Authorization.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.Bind("ConnectionString", new Config());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsersRepository, EFUsersRepository>();
builder.Services.AddTransient<AuthOptions>();
builder.Services.AddDbContext<AuthDbContext>(x => x.UseSqlServer(Config.DefaultConnection));
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
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

app.UseAuthorization();

app.MapControllers();

app.Run();
