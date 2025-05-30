using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.IdentityModel.Tokens;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Security;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Application.Security;
using MusicLab.Application.Services;
using MusicLab.Infrastructure;
using MusicLab.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
    //.AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MusicLabContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("Main")));

builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IMemberService, MemberService>();
builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IMeetingService, MeetingService>();
builder.Services.AddScoped<IMeetingRepository, MeetingRepository>();
builder.Services.AddScoped<IPersonalEventService, PersonalEventService>();
builder.Services.AddScoped<IPersonalEventRepository, PersonalEventRepository>();

//Configure TokenManager

TokenManager.Config config = builder.Configuration
    .GetSection("JWT")
    .Get<TokenManager.Config>() ?? throw new Exception("Missing JWT Config");

builder.Services.AddSingleton<ITokenManager, TokenManager>(
    _ => new TokenManager(config)
    );


// Configure Authentication Middleware
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(o => o.TokenValidationParameters = new TokenValidationParameters
{
    ValidateAudience = true,
    ValidAudience = config.Audience,
    ValidateIssuer = true,
    ValidIssuer = config.Issuer,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.Secret))
});


builder.Services.AddCors(b => b.AddDefaultPolicy(o =>
{
    o.AllowAnyMethod();
    o.AllowAnyOrigin();
    o.AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();
