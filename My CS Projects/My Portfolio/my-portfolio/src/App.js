import React from 'react';
import './App.css';
import Navbar from './components/Navbar/Navbar';
import HeroImg from './components/HeroImg/HeroImg';
import Skills from './components/Skills/Skills';
import Footer from './components/Footer/Footer';
import FooterBorder from './components/Footer/FooterBorder/FooterBorder';

const App = () => {
  return (
    <div className='App'>
        <Navbar/>
        <HeroImg/>
        <Skills/>
        <Footer/>
        <FooterBorder/>
    </div>
  );
};

export default App;