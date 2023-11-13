import React from 'react';

export const Input = (
    {
        type,
        id,
        value,
        required,
        additionalClass,
        className,
        placeHolder,
        manipulationFunction,
        

    }
) => {
    return (
        <input
            type={type}
            id={id}
            name= {name}
            value = {value}
            required={required}
            className = {`input-component ${additionalClass}`  }
            placeholder = {}
            manipulationFunction{}



        />
    )
}