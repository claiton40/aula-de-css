import React from 'react';
import './Title.css'

const Title = ({titleText, additionalClass = "" , color = ""}) => {
    return (
        
            <h1 className={`title ${additionalClass}`}
            style = {{color : color}}
            >
                {titleText}
                <hr />
            </h1>
        
    );
};

export default Title;