var builder = WebApplication.CreateBuilder(args);
//Adiciona o servico de controllers
builder.Services.AddControllers();
var app = builder.Build();

//mapeia os controllers
app.MapControllers();

app.Run();
