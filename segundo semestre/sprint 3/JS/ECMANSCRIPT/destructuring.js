const camisadobras =
{
Descricao: "Camisa chavosa",
preco: 39.90,
marca: "SoDeusSabe",
tamanho: "G",
Promocao: true,
Cor: "Azul"
}

// const descricao = camisadobras.Descricao
// const preco = camisadobras.preco

const {descricao, preco, Promocao} = camisadobras;


console.log(
    `Produto: ${descricao}
    Preco: ${preco}
    Promocao: ${Promocao ? "sim" : "nao"}
    }`
);

/* crie um objeto evento com as propriedades
DATA EVENTO
DESCRICAO DO EVENTO
TITULO
PRESENCA
COMENTARIOS
Crie um destrutucture das propriedades do objeto evento e as exiba no console
*/

 const evento = {
    Data:"10/09/1979",
    descricao2: "Role top",
    Titulo: "Festa no ape",
    presenca: true,
    comentario: "evento top"
}

const {Data, descricao2, Titulo, presenca, comentario} = evento

console.log(Data, descricao2, Titulo, presenca);