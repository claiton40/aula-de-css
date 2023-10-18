// const somar =  (x,y) =>
// {
//     return x + y
// }
//  console.log(somar(50,10));

//  const dobro = (n)=>
//  {
//     return n*2;
//  }
//  const dobro = n=>
//  {
//     return n*2;
//  }
//  const dobro = n => n*2;

//  console.log(dobro(10));
// const varzea = () => {console.log("varzea script")};

// [
//     "Jose",
//     "Maria",
//     "Rosa",
//     "Mao",
//     "Ming",
//     {nome: "Karl", idade: 44},
//     "Friedrich"]

// varzea();

const convidados = [
    {nome: "Karl", idade: 44},
    {nome: "Jose", idade: 42},
    {nome: "Maria", idade: 22},
    {nome: "Friedrich", idade: 50},
    ]

convidados.forEach( p => {
    console.log(`pessoa convidada: ${p}`)
})