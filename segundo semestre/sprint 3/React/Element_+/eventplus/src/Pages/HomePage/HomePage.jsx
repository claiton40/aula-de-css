import React from 'react';
import Title from '../../Components/Title/Title';
import Banner from '../../Components/Banner/Banner';
import VisionSection from '../../Components/VisionSection/VisionSection';
import MainContent from '../../Components/MainContent/MainContent';
import "./HomePage.css";

const HomePage = () => {
    return (
        <MainContent>
            <Banner/>
            <VisionSection />
        
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