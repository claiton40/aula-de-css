using Microsoft.IdentityModel.Tokens;

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
.AddJwtBearer(options => 
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        //valida quem ta solicitando pelo validade issuer
        ValidateIssuer = true,
        //valida o audience
        ValidateAudience = true,
        //define se o tempo de expiracao sera validado
        ValidateLifetime = true,
        //forma de criptografia
       IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi")),
        //valida o tempo de expiracao
        ClockSkew = TimeSpan.FromMinutes(5),
        //de onde esta vindo
        ValidIssuer = "webapi.filmes.tarde",
        //para onde esta indo
        ValidAudience = "webapi.filmes.tarde"
       
    };
});
var app = builder.Build();

//Usar Autorizacao
app.UseAuthorization();
//Usar Atenticacao
app.UseAuthentication();

//mapeia os controllers
app.MapControllers();

app.Run();