import React from 'react';
import Title from '../../Components/Title/Title';
import './EventosPage.css';
import MainContent from "../../Components/MainContent/MainContent";
import ImageIllustrator from '../../Components/ImageIllustrator/ImageIllustrator';
import eventImage from '../../assets/images/evento.svg'
import Container from "../../Components/Container/Container";
import { Input, Button, Select } from "../../Components/FormComponents/FormComponents";
import { useState, useEffect} from "react";
import api from "../../Services/Service"
import TableEv from './TableEv/TableEv';
import Notification from "../../Components/Notification/Notification"
import Spinner from "../../Components/Spinner/Spinner"



const EventosPage = () => {


  
  //useEfect
  useEffect(()=> {

    
    // chamar a api
    async function getEventos() {

   
      try {
        const promiseE = await api.get("/Evento");
        const promiseI = await api.get("/Instituicao");
        const promiseT = await api.get("/TiposEvento");
        
        setTipoEventos(promiseT.data);



        // const select = []

        // tipoEventos.forEach(
        //   (e) => 
        //   {
        //     value : e.idTipoEvento
        //     text : e.titulo
        //   }
        // )
        
        setTipoEventos2(promiseT.data);


        setEventos(promiseE.data);

        setIdInstituicao(promiseI.data[0].idInstituicao)

       
       

      } catch (error) {
        console.log('Deu ruim na api');
      }
    }
   
    getEventos();
    
      console.log("montou os eventos");
  }, []);
  

    //useStates (variáveis, nesse caso.)

    const [nome, setNome] = useState ("");
    
    const [idInstituicao, setIdInstituicao] = useState ("");

    const [descricao, setDescricao] = useState ("");

    const [data, setData] = useState ("");

    const [eventos, setEventos] = useState([]);

    const [tipoEventos, setTipoEventos] = useState([]);
    
    const [tipoEventos2, setTipoEventos2] = useState([]);

    const [idEvento, setIdEvento] = useState (null);

    

    const [notifyUser, setNotifyUser] = useState({})


    // funções (metodos)

    async function showUpdateForm(idElemento)
  {
    
    try {
      const retornoE = await api.get(`/Evento/`+ idElemento);
      const retornoT = await api.get(`/TiposEvento` + idElemento );
    setEventos(retornoE.data.nomeEvento);
    setIdEvento(retornoE.data.idEvento);
    setTipoEventos(retornoT.data.titulo);

    console.log(retornoE.data.nomeEvento);
    
    } catch (error) {
      console.log("erro na atualização da tela");
    }
  }

  async function handleSubmit(e)
  {
   //para submit do formulario
   e.preventDefault();
   //validar caracteres
   if (nome.trim().length<3)  {
    alert ("O nome deve ter mais de 3 caracteres")
    return
   }
   //chamar api
   try {
    const retorno = await api.post("/Evento", {nome,
    descricao,
    tipoEventos,
    data
    })
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
    setNome("");
    setDescricao("");
    setTipoEventos("");
    setData("");

    const retornoGet = await api.get("/Evento");
    setEventos(retornoGet.data)
   } catch (error) {
    setNotifyUser({
      titleNote: "Erro",
      textNote: `Falha ao Cadastrar!`,
      imgIcon: "warning",
      imgAlt:
        "Imagem de ilustração de erro.",
      showMessage: true,
    });
   }
  }

  async function handleDelete(idEvento)
  {
    try {
      const retorno = await api.delete(`/Evento/${idEvento}`);
    setNotifyUser({
      titleNote: "Sucesso",
      textNote: `Apagado com sucesso!`,
      imgIcon: "success",
      imgAlt:
        "Imagem de ilustração de sucesso. Moça segurando um balão com símbolo de confirmação ok.",
      showMessage: true,
    });

    const retornoGet = await api.get("/Evento");
    setEventos(retornoGet.data)
    
    } catch (error) {
      setNotifyUser({
        titleNote: "Erro",
        textNote: `Erro ao apagar`,
        imgIcon: "warning",
        imgAlt:
          "Imagem de ilustração de sucesso. Moça segurando um balão com símbolo de confirmação ok.",
        showMessage: true,
      });
    }
  }
    
//elemetos da tela

    return (
        <MainContent>
        {/* cadastrro de eventos */}
        <section className="cadastro-evento-section">
            <Container>
            <div className="cadastro-evento__box">
          <Title titleText={"Cadastro de Eventos"} />
          <ImageIllustrator 
            alterText={"??????"}
            imageRender={eventImage}
          />

<form className="ftipo-evento" onSubmit={handleSubmit}>
          <Input 
              type={"text"}
              id = {"nome"}
              name = {"nome"}
              placeholder = {"Nome"}
              required = {"required"}
              value = {nome}
              manipulationFunction = {
                (e) =>{
                  setNome(e.target.value)
                } 
              }
            />

            <Input 
              type={"text"}
              id = {"descricao"}
              name = {"descricao"}
              placeholder = {"Descrição"}
              required = {"required"}
              value = {descricao}
              manipulationFunction = {
                (e) =>
                {
                  setDescricao(e.target.value)
                }
              }
            />            

          <Select 
              value = {tipoEventos2}
              id = {tipoEventos2}
              dados={tipoEventos2}
              additionalClass = {tipoEventos2}
              manipulationFunction = {
                (e) =>
                {
                  setTipoEventos(e.target.value)
                }
              }
            />

          <Input 
              type={"date"}
              id = {"data"}
              name = {"data"}
              placeholder = {"Data do Evento"}
              required = {"required"}
              value = {data}
              manipulationFunction = {
                (e) =>{
                  setData(e.target.value)
                }
              }
            />

            <Button
            type={"submit"}
            id = {"cadastrar"}
            name = {"cadastrar"}
            textButton = {"Cadastrar"}
            />

          </form>

        </div>
            </Container>
        </section>
        <section className="lista-eventos-section">

        <Container>
          <Title  titleText={"Lista de tipos de eventos"} />
          <TableEv
          dados={eventos}
          dadosT={tipoEventos}
          fnUpdate = {showUpdateForm}
          fnDelete = {handleDelete}
          />
        </Container>

        </section>
        </MainContent>
    );
};

export default EventosPage;