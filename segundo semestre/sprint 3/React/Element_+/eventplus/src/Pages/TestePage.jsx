import React, { useState } from 'react';


import Input from '../Components/Input/Input';
import Header from '../Components/Header/Header';
import Button from '../Components/Button/Button';

const TestePage = () => {
    const [total, setTotal] = useState();
    const [n1, setN1] = useState();
    const [n2, setN2] = useState();

    function handleCalcular(e) {
        e.preventDefault()
        setTotal(parseFloat(n1) + parseFloat(n2))
    }
    return (
        <>
            <Header />
            <h1>Paginas de testes</h1>
            <h2>Calculadora da Alegria</h2>

            <form onSubmit={handleCalcular}>
                <Input
                    tipo="number"
                    id="numero1"
                    nome="numero1"
                    dicaCampo="Primeiro numero"
                    valor={n1}
                    fnAltera={setN1}
                />
                <Input
                    tipo="number"
                    id="numero2"
                    nome="numero2"
                    dicaCampo="Segundo numero"
                    valor={n2}
                    fnAltera={setN2}
                />

                <Button tipo="submit"
                    textoBotao="somar" />

                <p>Resultado: <strong>{total}</strong></p>
            </form>


        </>
    );
};

export default TestePage;