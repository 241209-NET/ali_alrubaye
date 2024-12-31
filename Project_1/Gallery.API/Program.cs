using Gallery.API.Data;
using Gallery.API.Repository;
using Gallery.API.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Adding DbContext with connection string
builder.Services.AddDbContext<GalleryContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Gallery")));

//Add service dependencies
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPaintingService, PaintingService>();

//Add repo dependencies
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPaintingRepository, PaintingRepository>();

//Adding controllers
builder.Services.AddControllers().AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Mapping controllers
app.MapControllers();
app.Run();

