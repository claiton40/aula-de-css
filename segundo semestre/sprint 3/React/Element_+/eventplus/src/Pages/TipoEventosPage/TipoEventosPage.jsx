import React from 'react';
import Title from '../../Components/Title/Title';
import "./TipoEventosPage.css"
import Maincontent from "../../Components/MainContent/MainContent"
import ImageIlustrator from '../../Components/ImageIlustrator/ImageIlustrator';
import eventTypeImage from '../../assets/images/tipo-evento.svg'
import Container from '../../Components/Container/Container'

const TipoEventosPage = () => {
    return (
        <Maincontent>
            <section className="cadastro-evento-section">
                <Container>
                <div className="cadastro-evento__box">
                    <Title titleText="Pagina dos tipos de Eventos"/>
                    <ImageIlustrator/>
                    <form action = "">
                        <p>Componente de formulario</p>
                    </form>
                </div>
                </Container>

            </section>
        </Maincontent>
    );
};

export default TipoEventosPage;