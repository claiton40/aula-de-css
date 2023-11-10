import React, { useEffect, useState } from "react"

function Exemplo() {
  
  //usestate
  const [array, setArray] = useState([]);
  const [count, setCount] = useState(0);

  //useEfect
  useEffect (() =>{
    setTimeout(() => {
    setCount(() => count + 1);
    }, 1000);
    
  })

  //função para obter dados
  const obterDados = async () => {

    const dados = await fetch('https://jsonplaceholder.typicode.com/photos')
    const converter = await dados.json();
    
  }

  

  return(
    <div>
      
   
      <h1>I've rendered {count} times!</h1>;
     
      <img src="https://via.placeholder.com/600/771796">
      </img> 

    </div>
  )
}

export default Exemplo;