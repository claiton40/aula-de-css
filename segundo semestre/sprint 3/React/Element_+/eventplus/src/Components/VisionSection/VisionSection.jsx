import React from 'react';
import Title from '../Title/Title'
import './VisionSection.css';

const VisionSection = () => {
    return (
       <section className='vision'>
        <div className='vision__box'>
            
            <Title 
            titleText={"Visao"}
            color='white'
            additionalClass='visionTitles'/>
            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Soluta quod minus laborum excepturi hic aperiam quia sit minima alias tempore quo quibusdam dolor sapiente dolore, similique eos repellendus nesciunt porro!
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt molestiae provident laborum id ratione, labore, fugit totam nobis et at nisi eum quisquam alias asperiores odio dolorem laudantium tempora fuga.
            </p>
            
        </div>

       </section>
    );
};

export default VisionSection;