using IronSwords.Repositories;
using IronSwords.Services;
using IronSwords.Repositories.Entities;
using IronSwords.Repositories.Interfaces;
using IronSwords.WebApi;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(opt => opt.AddPolicy("CorsPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));
builder.Services.AddDbContext<IContext, MyDbContext>();
builder.Services.AddRepository();
builder.Services.AddServices();
builder.Services.AddAutoMapper(typeof(Mapping));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
