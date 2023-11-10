import React from "react";
import './HomePage.css'
import MainContent from "../../Components/MainContent/MainContent";
import Banner from "../../Components/Banner/Banner";
import VisionSection from "../../Components/VisionSection/VisionSection";
import ContactSection from "../../Components/ContactSection/ContactSection";
import NextEvent from "../../Components/NextEvent/NextEvent";
import Title from "../../Components/Title/Title";
import Container from "../../Components/Container/Container";
import { useEffect, useState } from "react";
import ReactDOM from "react-dom/client";

const HomePage = () => {

  useEffect(() => {
    
  }, [])
  
  const [verEvento, setverEvento] = useState( [{id: 1, nome: "evento merda", data: "10/09/1979"}, {id: 2, nome: "evento top", data: "10/09/1979"}])

 
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
          verEvento.map((e) => {
          return (
          <NextEvent 
          title= {e.nome} 
          description={e.descricao}
          eventDate={e.data}
          idEvento={e.id} />
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