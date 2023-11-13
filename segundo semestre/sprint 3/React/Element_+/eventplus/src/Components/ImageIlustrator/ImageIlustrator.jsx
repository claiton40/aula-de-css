import React from 'react';
import imageDefaut from "../../assets/images/default-image.jpeg"

const ImageIlustrator = ({alterText, ImageRender = imageDefaut, adtionalClass = "ilustrator-box__image"}) => {
    return (
        <figure>
            <img 
            src= {ImageRender}
            alt={alterText}
            className= {`ilustrator-box__image ${adtionalClass}`}
             />
        </figure>
    );
};

export default ImageIlustrator;