import React from "react";
import './CardEvento.css';

const CardEvento = (props) =>
{
    return  ( <div class="card-evento">
    <h3 class="card-evento__titulo">{props.titulo} </h3>
    <p class="card-evento__text">{props.descricao}</p>
   <a href="" class="card-evento__conection">Conectar</a>
</div> )
}

export default CardEvento;