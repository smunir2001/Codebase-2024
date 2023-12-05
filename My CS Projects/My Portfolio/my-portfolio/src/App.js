import React from 'react';
import './App.css';
import Navbar from './components/Navbar/Navbar';
import HeroImg from './components/HeroImg/HeroImg';
import Skills from './components/Skills/Skills';

const App = () => {
  return (
    <div className='App'>
        <Navbar/>
        <HeroImg/>
        <Skills/>
    </div>
  );
};

export default App;