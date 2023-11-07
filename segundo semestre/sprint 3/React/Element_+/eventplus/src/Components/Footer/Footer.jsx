import React from 'react';
import './Footer.css';

const Footer = ({textRigths = "Escola do Claitinho"}) => {
    return (
        <footer className='footer-page'>
            <p className='footer-page__rights'>{textRigths}</p>
        </footer>
    );
};

export default Footer;