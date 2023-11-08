import React from 'react';
import './ContactSection.css'
import contatoMap from '../../assets/images/contato-map.png'
import Title from '../../Components/Title/Title';

const ContactSection = () => {
    return (
       <section className='contato'>
        <Title titleText={"Contato"}/>
        <div className='contato__endereco-box'>
            <img src={contatoMap} alt="" 
            className='contato__img-map'/>

        </div>
       </section>
    );
};

export default ContactSection;