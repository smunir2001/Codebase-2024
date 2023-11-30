import React from 'react';
import './App.css';
import Navbar from './components/Navbar/Navbar';
import HeroImg from './components/HeroImg/HeroImg';

const App = () => {
  return (
    <div className='App'>
        <Navbar/>
        <HeroImg/>
    </div>
  );
};

export default App;