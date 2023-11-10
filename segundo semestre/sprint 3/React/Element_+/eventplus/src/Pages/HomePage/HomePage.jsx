import React from "react";
import './HomePage.css'
import MainContent from "../../Components/MainContent/MainContent";
import Banner from "../../Components/Banner/Banner";
import VisionSection from "../../Components/VisionSection/VisionSection";
import ContactSection from "../../Components/ContactSection/ContactSection";
import NextEvent from "../../Components/NextEvent/NextEvent";
import Title from "../../Components/Title/Title";
import Container from "../../Components/Container/Container";
import { useEffect, useState, } from "react";
import ReactDOM from "react-dom/client";
import axios from "axios";

const HomePage = () => {

  useEffect( () => {
    
    async function getProximosEventos(){
    try {
      
        const promisse  = await axios.get (
          "http://localhost:5000/api/Evento/ListarProximos"
        )
  
        setNextEvents(promisse.data)
        }
    
    catch (error) {
       
          
    }
  }
    getProximosEventos();

  }, [])
  
  const [nextEvents, setNextEvents] = useState ([]);
 


  return (
    <MainContent>
      <Banner />

      {/* PRÓXIMOS EVENTOS */}
      <section className="proximos-eventos">
        <Container>
          <Title titleText={"Próximos Eventos"} />

          <div className="events-box">
            
          {
          // execulta em cada elemento do array
          nextEvents.map((e) => {
          return (
          <NextEvent 
          title= {e.nomeEvento} 
          description={e.descricao}
          eventDate={e.dataEvento}
          idEvento={e.idEvento} />
                );
                                }
                        )
          }  
          </div>
        </Container>
      </section>

      <VisionSection />
      <ContactSection />
    </MainContent>
  );
};

export default HomePage;