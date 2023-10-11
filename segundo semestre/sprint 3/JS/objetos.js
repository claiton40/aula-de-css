let claiton = 
{
    nome: "Claiton",
    idade: 44,
    altura: 1.74
};

claiton.formacao = `Psicologia`


let dinossauro = new Object();

dinossauro.nome= `galinhosauro`
dinossauro.cor = `azul calcinha`
dinossauro.tamanho = `grande pra dede`
dinossauro.existe = true


let coisas = []

coisas.push(claiton)
coisas.push(dinossauro)

//console.log(coisas)

coisas.forEach(function(v, n)
{
console.log(`Nomes ${n+1}: ${v.nome}`)
}
)