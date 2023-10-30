import React, { useState } from "react";
import "./Contador.css"

const Contador = () => {

  const [contador, setContador] = useState(0)

  function hadleIncrementar()
  {
    setContador(contador + 1)
  }

   function hadledecrementar()
  {
    setContador(contador - 1)
    if (contador <= 0)
    {
        setContador(contador - contador)
        
    }
  }

  function hadledereset()
  {
    setContador(contador - contador)
  }
    return (<>
    
    <h1>{contador}</h1>
    <button onClick={hadleIncrementar}>Incrementar</button>
    <br />
    <br />
    <button onClick={hadledecrementar}>Decrementar</button>
    <br />
    <br />
    <button onClick={
        //encapsulando a funcao em um ArowFunction, pos o react executa automaticamente a funcao, por isso nao posso invoca-la no codigo sem esse encapsulamento.
        () => {hadledereset()}}
        >Reset</button>
         <br />
        <br /> 
        <br />
        <br />
    </>)
}

export default Contador;