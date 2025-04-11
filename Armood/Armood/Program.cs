using Armood.Application.Services.Authorize;
using Armood.Domain.Services.Authorize;
using Armood.Repository.Repositories.Authorize;
using Armood.SQLServer.Repositories.AuthRepository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "API",
        Version = "v1"
    });
});
builder.Services.AddControllers();


//builder.Services.AddScoped<IAuthRepository,AuthRepository>();
builder.Services.AddScoped<IAuthRepository>(provider => new AuthRepository(connectionString, builder.Configuration));
builder.Services.AddScoped<IAuthService, AuthService>();



var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

