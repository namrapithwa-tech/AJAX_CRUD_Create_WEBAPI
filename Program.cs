using AJAX_CRUD_Create_WEBAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Register Swagger services

// Add your UserRepository
builder.Services.AddScoped<UserRepository>(sp =>
    new UserRepository(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add CORS (if needed for frontend communication)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost7033", policy =>
    {
        policy.WithOrigins("https://localhost:7033")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Add Swagger middleware
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowLocalhost7033"); // Enable CORS

app.UseAuthorization();

app.MapControllers();

app.Run();
