import React from 'react';
import './HomePage.css'
import Title from '../../Components/Title/Title';
import Banner from '../../Components/Banner/Banner';
import VisionSection from '../../Components/VisionSection/VisionSection';
import MainContent from '../../Components/MainContent/MainContent';
import ContactSection from '../../Components/ContactSection/ContactSection';
import NextEvent from '../../Components/NextEvent/NextEvent';
import "./HomePage.css";
import Container from '../../Components/Container/Container'

const HomePage = () => {
    return (
        <MainContent>
            <Banner/>
            {/* PRÓXIMOS EVENTOS */}
      <section className="proximos-eventos">
        <Container>
          <Title titleText={"Próximos Eventos"} />

          <div className="events-box">
            
            <NextEvent
              title={"Resenha dos trutas"}
              description={"Muita curticao e azaracao"}
              eventDate={"14/11/2023"}
              idEvento={"jqwelkhiyt98iuqr2"}
            />
            <NextEvent
              title={"Resenha dos trutas"}
              description={"Muita curticao e azaracao"}
              eventDate={"14/11/2023"}
              idEvento={"jqwelkhiyt98iuqr2"}
            />
            <NextEvent
              title={"Resenha dos trutas"}
              description={"Muita curticao e azaracao"}
              eventDate={"14/11/2023"}
              idEvento={"jqwelkhiyt98iuqr2"}
            />
            <NextEvent
              title={"Resenha dos trutas"}
              description={"Muita curticao e azaracao"}
              eventDate={"14/11/2023"}
              idEvento={"jqwelkhiyt98iuqr2"}
            />
            <NextEvent
              title={"Resenha dos trutas"}
              description={"Muita curticao e azaracao"}
              eventDate={"14/11/2023"}
              idEvento={"jqwelkhiyt98iuqr2"}
            />
          </div>
        </Container>
      </section>
            <VisionSection />
            <ContactSection/>
        
            <h1>Página Home</h1>
            <div>
                <Title
                titleText={"Claiton da massa"}
                 color='red'

                />
            </div>
        </MainContent>
    );
};

export default HomePage;