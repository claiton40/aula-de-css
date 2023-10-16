function calcular(e)
{
    //segura os dados antes de ir para o form. seve para o dado ficar visivel no console
    e.preventDefault();
    console.log("calc imc");
    //atribuicao das varia que vao pegar os dados do formulario
    let nome = document.getElementById("nome").value.trim();
    let peso = parseFloat (document.getElementById("peso").value);
    let altura = parseFloat ( document.getElementById("altura").value);
    
if (isNaN(altura) || isNaN(peso) || nome.length <= 2) 
{
    alert ('Preencha todos os campos')
    return;
}
const imc = calcularImc(peso, altura)
const situacao = geraSituacao(imc)
//os consolelog e so pra teste
    console.log(nome);
    console.log(peso);
    console.log(altura);
    console.log(imc);
    console.log(situacao);
} // fim da funcao calcular

function calcularImc(peso, altura)
{
    return peso / (altura * altura)
}// fim da funcao caccularImc


/*
    Resultado	        Situação
    Menor que 18.5      Magreza Severa
    Entre 18.5 e 24.99	Peso normal
    Entre 25 e 29.99	Acima do peso
    Entre 30 e 34.99	Obesidade I
    Entre 35 e 39.99	Obesidade II (severa)
    Acima de 40	        Cuidado!!! else
*/
function geraSituacao(imc)
{
    if (imc < 18.5)
    {

        return 'Magreza Severa';
    } 
    else if (imc >= 18.5 && imc <= 24.99)
    {
        return 'Peso normal';
    }
    else if (imc >= 25 && imc <= 29.99)
    {
        return "Acima do peso";
    }
    else if (imc >= 30 && imc <= 34.99)
    {
        return 'Obesidade I';
    } 
    else if (imc >= 35 && imc <= 39.99)
    {
        return 'Obesidade II (severa)';
    } 
    else
    { //a partir de 40
        return 'Cuidado!!!';
    }
}