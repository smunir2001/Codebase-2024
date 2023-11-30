import React from 'react';
import './Navbar.css';
import { FaGithub } from "react-icons/fa";
import { CiLinkedin } from "react-icons/ci";

const Navbar = () => {
  return (
    <div className='navbar-con'>
        <div className='navbar-logo-con'>
            {/* <h1>Munir Code Crafters</h1> */}
            <h1>Munir Code Forge</h1>
        </div>
        <div className='navbar-links-con'>
            <ul>
                <li><a href="/">Home</a></li>
                <li><a href="/">Skills</a></li>
                <li><a href="/">Projects</a></li>
            </ul>
        </div>
        <div className='navbar-socials-links-con'>
            <ul>
                <li><a href="/"><FaGithub/></a></li>
                <li><a href="/"><CiLinkedin/></a></li>
            </ul>
        </div>
        <div className='navbar-connectwm-button-con'>
            <button type='button'>Let's Connect</button>
        </div>
    </div>
  );
};

export default Navbar;