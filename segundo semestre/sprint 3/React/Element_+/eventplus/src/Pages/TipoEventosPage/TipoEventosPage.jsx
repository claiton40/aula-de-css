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
import Spinner from "../../Components/Spinner/Spinner"


const TipoEventosPage = () => {


  useEffect(()=> {
    // chamar a api
    async function getTiposEventos() {

      setshowSpinner(true);
      try {
        const promise = await api.get("/TiposEvento");

        setTipoEventos(promise.data);

      } catch (error) {
        console.log('Deu ruim na api');
      }
    }
   
    getTiposEventos();
    setshowSpinner(false);
      console.log("montou os eventos");
  }, []);
  

  const [frmEdit, sefrmEdit ] = useState (true);

  const [titulo, setTitulo] = useState ("");

  const [tipoEventos, setTipoEventos] = useState([]);

  const [notifyUser, setNotifyUser] = useState({})

  const [idEvento, setIdEvento] = useState (null);

  const [showSpinner, setshowSpinner] = useState (false);

   

  
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

    const retornoGet = await api.get("/TiposEvento");
    setTipoEventos(retornoGet.data)
   } catch (error) {
    
   }
  }

 async function handleUpdate(e) 
  {
    e.preventDefault();

    try {

      const retorno = await api.put(`/TiposEvento/` + idEvento, {
        titulo : titulo
      }) 

      const retornoGet = await api.get (`/TiposEvento`);
      setTipoEventos(retornoGet.data);
      editActionAbort();
      alert("funcionou o role")
      
    } catch (error) {
      alert("falhou o role")
      console.log(error);
    }

  }

 async function showUpdateForm(idElemento)
  {
    sefrmEdit(true);
    try {
      const retorno = await api.get(`/TiposEvento/`+ idElemento);
    setTitulo(retorno.data.titulo);
    setIdEvento(retorno.data.idTipoEvento);
    } catch (error) {
      alert("falhou o role")
    }
  }

 async function handleDelete(idTipoEvento)
  {
    try {
      const retorno = await api.delete(`/TiposEvento/${idTipoEvento}`);
    setNotifyUser({
      titleNote: "Sucesso",
      textNote: `Apagado com sucesso!`,
      imgIcon: "success",
      imgAlt:
        "Imagem de ilustração de sucesso. Moça segurando um balão com símbolo de confirmação ok.",
      showMessage: true,
    });

    const retornoGet = await api.get("/TiposEvento");
    setTipoEventos(retornoGet.data)
    
    } catch (error) {
      
    }
  }

  function editActionAbort()
  {
    sefrmEdit(false);
    setTitulo("");
    setIdEvento(null);
  }

  return (
    <MainContent>
      <Notification {...notifyUser} setNotifyUser={setNotifyUser} />
      {showSpinner ? <Spinner/> : null}
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
            
            (
              <>
              <Input
              id = {"Titulo"}
              placeholder = {"Titulo"}
              name = {"titulo"}
              type = {"text"}
              required = {"required"}
              value = {titulo}
              manipulationFunction = {(e) => {
                setTitulo(e.target.value)
              }}
              />

              <div className="buttons-editbox">
              <Button
               type={"submit"}
               id = {"atualizar"}
               name = {"atualizar"}
               textButton = {"Atualizar"}

               additionalClass = {"butto-component--middle"}
                />
                
                <Button
               type={"button"}
               id = {"cancelar"}
               name = {"cancelar"}
               textButton = {"Cancelar"}
               manipulationFunction={editActionAbort}
               additionalClass = {"butto-component--middle"}
                />
              </div>
              </>
            )}
           
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
