using Microsoft.EntityFrameworkCore;
using OnlineEdu.DataAccess.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*veritaban� baglant�s�n� burada verd�k appsettings.json taraf�nda sqlconnection isminde degiskene
 atad�g�m�z �c�n burada �sm�n� verm�s olduk*/
builder.Services.AddDbContext<OnlineEduContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
});
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
