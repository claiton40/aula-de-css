import React from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import HomePage from "./Pages/Homepage/HomePage"
import LoginPage from "./Pages/LoginPage/LoginPage"
import ProdutosPage from "./Pages/ProdutoPage/ProdutoPage"


const Rotas= () => {
    return (
       <BrowserRouter>
        <Routes>
            <Route element = {<HomePage/>} path ="/"exact />
            <Route element = {<LoginPage/>} path =""Login />
            <Route element = {<ProdutosPage/>} path =""Produtos />
        </Routes>
       </BrowserRouter>
    );
};

export default Rotas;