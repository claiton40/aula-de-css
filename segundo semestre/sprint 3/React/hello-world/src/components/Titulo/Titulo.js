import React from "react";
import './Titulo.css';

//context API
const Titulo = (props) => 
{
    return (  <h2 className="titulo"> Ola {props.texto}, o Capitalismo falhou, falha e falhara</h2>);
}

export default Titulo;