var builder = WebApplication.CreateBuilder(args);
//Adiciona o servico de controllers
builder.Services.AddControllers();
//adicona servico de autenticacao jwt bearer
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "JwtBearer";
    options.DefaultAuthenticateScheme = "JwtBearer";
})

//define os parametros de validacoa do token
.AddJwtBearer(options => { });
    
var app = builder.Build();

//mapeia os controllers
app.MapControllers();

app.Run();
