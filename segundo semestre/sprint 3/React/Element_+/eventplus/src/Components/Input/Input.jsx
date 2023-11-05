import React, { useState } from 'react';

const Input = (props) => {
    const [meuValor, setMeuValor] = useState();
    return (

        <div>
            <input
                type={props.tipo}
                id={props.id}
                name={props.nome}
                placeholder={props.dicaCampo}
                value={props.valor}
                onChange={(e) => {
                    props.fnAltera(e.target.value)
                }}
            />
            <span>{meuValor}</span>
        </div>
    );

};

export default Input;