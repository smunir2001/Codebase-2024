import React from 'react';
import './App.css';
import Navbar from './components/Navbar/Navbar';
import HeroImg from './components/HeroImg/HeroImg';
import Skills from './components/Skills/Skills';
import Footer from './components/Footer/Footer';

const App = () => {
  return (
    <div className='App'>
        <Navbar/>
        <HeroImg/>
        <Skills/>
        <Footer/>
    </div>
  );
};

export default App;