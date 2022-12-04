using System.Text.Json.Serialization;
using InimcoCase.Domain.Repositories;
using InimcoCase.Domain.Services;
using InimcoCase.Util;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    } );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerDocument();

builder.Services.AddTransient<IUserSocialProfileRepository, UserSocialProfileRepository>();
builder.Services.AddTransient<IUserSocialProfileService, UserSocialProfileService>();
builder.Services.AddCors(p => p.AddPolicy("Inimco", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUi3();
    app.UseOpenApi();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseCors("Inimco");

app.Run();
