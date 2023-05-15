using BussinesLogic.Interfaces;
using BussinesLogic.Services;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string connStr = builder.Configuration.GetConnectionString("LocalDb");

builder.Services.AddDbContext<Data.Data.DbContext>(options => options.UseSqlServer(connStr));
builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<Data.Data.DbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var dir = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).FullName,
    "BussinesLogic", "Images");
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(dir),
    RequestPath = "/images"
});

app.UseHttpsRedirection();

app.UseCors(
    builder => builder
        .AllowAnyOrigin()
        .SetIsOriginAllowedToAllowWildcardSubdomains()
        .AllowAnyMethod()
        .AllowAnyHeader()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
