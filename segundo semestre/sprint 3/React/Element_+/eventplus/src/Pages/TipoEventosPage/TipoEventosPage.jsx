import React from "react";
import Title from "../../Components/Title/Title";
import "./TipoEventosPage.css";
import MainContent from "../../Components/MainContent/MainContent";
import ImageIllustrator from '../../Components/ImageIllustrator/ImageIllustrator';

import eventTypeImage from '../../assets/images/tipo-evento.svg'
import Container from "../../Components/Container/Container";
import { Input, Button } from "../../Components/FormComponents/FormComponents";
import { useState } from "react";
import api from "../../Services/Service"


const TipoEventosPage = () => {

  const [frmEdit, sefrmEdit ] = useState (false);

  const [titulo, setTitulo] = useState ("");

  async function handleSubmit(e) {
   //para submit do formulario
   e.preventDefault();
   //validar caracteres
   if (titulo.trim().length<3)  {
    alert ("o titulo deve ter mais de 3 caracteres")
    return
   }
   //chamar api
   try {
    const retorno = await api.post("/TiposEvento", {titulo: titulo})
    console.log("cadastrado com sucessp");
    console.log(retorno.data);
   } catch (error) {
    
   }
  }

 

  function handleUpdate() {
    alert("editando")

  }


  return (
    <MainContent>
      <section className="cadastro-evento-section">
        <Container>
        <div className="cadastro-evento__box">
          <Title titleText={"Página Tipos de Eventos"} />
          <ImageIllustrator 
            alterText={"??????"}
            imageRender={eventTypeImage}
          />

          <form className="ftipo-evento" onSubmit={frmEdit ? handleUpdate : handleSubmit}>
            {!frmEdit ? (<>
              <Input 
              type={"text"}
              id = {"titulo"}
              name = {"titulo"}
              placeholder = {"Titulo"}
              required = {"required"}
              value = {titulo}
              manipulationFunction = {
                (e) =>{
                  setTitulo(e.target.value)
                } 
              }
            />

           
            <Button
            type={"submit"}
            id = {"cadastrar"}
            name = {"cadastrar"}
            textButton = {"Cadastrar"}
            />
             
            </>) :
            
            (<p>Tela de edicao</p>)}
           
            {/*  */}
          </form>
        </div>
        </Container>
      </section>
    </MainContent>
  );
};

export default TipoEventosPage;
