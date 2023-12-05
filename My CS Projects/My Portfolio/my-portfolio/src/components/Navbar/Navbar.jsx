import React from 'react';
import './Navbar.css';
import { FaGithub } from "react-icons/fa";
import { CiLinkedin } from "react-icons/ci";
import { CiMail } from "react-icons/ci";
import { FaHome } from "react-icons/fa";
import { FaTasks } from "react-icons/fa";
import { FaLaptopCode } from "react-icons/fa";

const Navbar = () => {
  return (
    <div className='navbar-con'>
        <div className='navbar-logo-con'>
            <h1>Munir Code Forge</h1>
        </div>
        <div className='navbar-links-con'>
            <ul>
                <li><a href="/"><div><FaHome/><span className='navbar-links-con-link_text'>Home</span></div></a></li>
                <li><a href="/"><div><FaTasks/><span className='navbar-links-con-link_text'>Skills</span></div></a></li>
                <li><a href="/"><div><FaLaptopCode/><span className='navbar-links-con-link_text'>Projects</span></div></a></li>
            </ul>
        </div>
        <div className='navbar-socials-links-con'>
            <ul>
                <li><a href="/"><FaGithub/></a></li>
                <li><a href="/"><CiLinkedin/></a></li>
                <li><a href="/"><CiMail/></a></li>
            </ul>
        </div>
        <div className='navbar-connectwm-button-con'>
            <button type='button'>Let's Connect</button>
        </div>
    </div>
  );
};

export default Navbar;