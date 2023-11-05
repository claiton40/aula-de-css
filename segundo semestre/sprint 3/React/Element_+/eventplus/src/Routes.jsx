import React from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom"

import HomePage from './Pages/HomePage/HomePage';
import TiposEventos from './Pages/TiposEventosPage/TiposEventos';
import Eventos from './Pages/EventosPage/EventosPage';

import Header from './Components/Header/Header';

import Footer from './Components/Footer/Footer';

import TestePage from './Pages/TestePage';


const routes = () => {
    return (
        <div>

            <BrowserRouter>
                <Header/>
                <Routes>
                    <Route element={<HomePage />} path='/' exact />
                    <Route element={<TiposEventos />} path='/tipo-eventos' />
                    <Route element={<Eventos />} path='/eventos' />
                    <Route element={<TestePage />} path='/teste-page'/>
                </Routes>
                <Footer />
            </BrowserRouter>
        </div>
    );
};

export default routes;