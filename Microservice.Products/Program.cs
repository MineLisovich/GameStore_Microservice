using Microservice.Products.Data;
using Microservice.Products.Data.Repositories.Abstract;
using Microservice.Products.Data.Repositories.EntityFramework;
using Microservice.Products.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.Bind("ConnectionString", new Config());
// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(x =>
 x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<AuthOption>();

builder.Services.AddScoped<IDevelopers, EFDevelopers>();
builder.Services.AddScoped<IGames,EFGames>();
builder.Services.AddScoped<IGamesKeys,EFGamesKeys>();
builder.Services.AddScoped<IGanres,EFGanres>();
builder.Services.AddScoped<IPlatforms,EFPlatforms>();
builder.Services.AddScoped<IShares,EFShares>();

builder.Services.AddScoped<DataManager>();
builder.Services.AddDbContext<ProductsDbContext>(x => x.UseSqlServer(Config.DefaultConnection));
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
    option =>
    {

        option.RequireHttpsMetadata = false; // елсли  если равно false, то SSL при отправке токена не используется. Однако данный вариант установлен только дя тестирования. В реальном приложении все же лучше использовать передачу данных по протоколу https.
        option.SaveToken = true;
        option.TokenValidationParameters = new TokenValidationParameters
        {
            //указывает, будет ли валидироваться создатель при валидации токена
            ValidateIssuer = true,
            //строка представляющая издателя
            ValidIssuer = AuthOption.ISSUER,

            //будет ли валидироваться потребитель токена
            ValidateAudience = true,
            //установка потребителя токена
            ValidAudience = AuthOption.AUDIENCE,

            //будет ли валидироваться время существования токена
            ValidateLifetime = true,

            //установка секретного ключа
            IssuerSigningKey = AuthOption.GetSymmetricSecurityKey(),
            //валидация секретного ключа
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
app.UseStatusCodePages(async context =>
{
    var request = context.HttpContext.Request;
    var response = context.HttpContext.Response;

    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
    {
        response.Redirect("https://localhost:7044/Account/Login");
    }
});
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
