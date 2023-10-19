// Principais funcoes do ARRAY
// Foreeach = void
// Map = retorna um novo array modicficado
// filter = retorna um array que atenda um condicao
// reduce = volta um valor unificado array


const numeros = [1, 2, 5, 10, 300, "jose"]

//aplicacao da funcao map
const dobro = numeros.map((n) => {
    return n * 2
});

//aplicacao da funcao filter
const exFilter = numeros.filter((e) =>{
return e > 10
})
//aplicacao da funcao Reduce
const exReduce = numeros.reduce((vli, vlp)=>{
    return vli + vlp
},200) 



console.log(numeros);
console.log(dobro);
console.log(exFilter);
console.log(exReduce);


