import React from "react";
import Title from "../../Components/Title/Title";
import "./TipoEventosPage.css";
import MainContent from "../../Components/MainContent/MainContent";
import ImageIllustrator from '../../Components/ImageIllustrator/ImageIllustrator';

import eventTypeImage from '../../assets/images/tipo-evento.svg'
import Container from "../../Components/Container/Container";
import { Input, Button } from "../../Components/FormComponents/FormComponents";
import { useState, useEffect} from "react";
import api from "../../Services/Service"
import TableTp from "./TableTp/TableTp";
import Notification from "../../Components/Notification/Notification"


const TipoEventosPage = () => {


  useEffect(()=> {
    // chamar a api
    async function getTiposEventos() {
      try {
        const promise = await api.get("/TiposEvento");

        setTipoEventos(promise.data);

      } catch (error) {
        console.log('Deu ruim na api');
      }
    }
    getTiposEventos();
      console.log("montou os eventos");
  }, []);
  

  const [frmEdit, sefrmEdit ] = useState (false);

  const [titulo, setTitulo] = useState ("");

  const [tipoEventos, setTipoEventos] = useState([]);

  const [notifyUser, setNotifyUser] = useState({})

  
  // {idTipoEvento: "123", titulo: "Evento teste"},
  // {idTipoEvento: "223", titulo: "Evento teste333"},
  // {idTipoEvento: "333", titulo: "Evento teste444"},

  async function handleSubmit(e)
  {
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
    console.log("cadastrado com sucesso");
    setNotifyUser({
      titleNote: "Sucesso",
      textNote: `Cadastrado com sucesso!`,
      imgIcon: "success",
      imgAlt:
        "Imagem de ilustração de sucesso. Moça segurando um balão com símbolo de confirmação ok.",
      showMessage: true,
    }); 
    console.log(retorno.data);
    setTitulo("");
   } catch (error) {
    
   }
  }

  function handleUpdate() 
  {
    alert("editando")
  }

  function showUpdateForm()
  {
    alert("alertando")
  }

 async function handleDelete(idTipoEvento)
  {
    const retorno = await api.delete(`/TiposEvento/${idTipoEvento}`);
    const retornoGet = await api.get("/TiposEvento");
    setTipoEventos(retornoGet.data)
    
  }

  function editActionAbort()
  {
    alert("alertando")
  }

  return (
    <MainContent>
      <Notification {...notifyUser} setNotifyUser={setNotifyUser} />
      {/* cadastrro de eventos */}
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
      {/* listagem dos tipos */}
      <section className="lista-eventos-section">
        <Container>
          <Title  titleText={"Lista de tipos de eventos"} />
          <TableTp
          dados={tipoEventos}
          fnUpdate = {showUpdateForm}
          fnDelete = {handleDelete}
          />
          
        </Container>
      </section>
    </MainContent>
  );
};

export default TipoEventosPage;
