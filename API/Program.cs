using API.Extensions;
using API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

if(builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();

app.UseCors(corsPolicyBuilder => {
    corsPolicyBuilder.AllowAnyHeader().AllowAnyMethod().WithOrigins( new string[] { "http://localhost:4200", "https://localhost:4200" });
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
