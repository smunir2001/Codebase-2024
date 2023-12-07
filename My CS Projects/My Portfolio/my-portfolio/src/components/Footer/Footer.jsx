import React from 'react';
import './Footer.css';
import { FaGithub } from "react-icons/fa";
import { FaLinkedin } from "react-icons/fa";
import { FaInstagram } from "react-icons/fa";
import { FaTwitter } from "react-icons/fa";
import { FaFacebook } from "react-icons/fa";

const Footer = () => {
  return (
    <div className='footer-con'>
        <div className='footer-con-col1'>
            <h1>Have a project in mind?</h1>
            <h2>Let's talk!</h2>
            <p>
                With my expertise in Full-Stack Development and Systems 
                Programming, I am confident we can create something exceptional.
                Send a message, let's forge code!
            </p>
            <p>
                Feel free to fill out the form on the right to get in touch!
            </p>
            <div className='cwm-icons-con'>
                <FaGithub/>
                <FaLinkedin/>
                <FaInstagram/>
                <FaTwitter/>
                <FaFacebook/>
            </div>
        </div>
        <div className='footer-con-col2'>
            <h1>Connect with me!</h1>
            <form id='connect-with-me' action='' method='post'>
                <fieldset>
                    <input placeholder='Your name' type='text' tabIndex='1' required/>
                </fieldset>
                <fieldset>
                    <input placeholder='Your Email Address' type='email' tabIndex='2' required/>
                </fieldset>
                <fieldset>
                    <textarea placeholder='Type your Message Here...' maxLength='500' tabIndex='5' required></textarea>
                </fieldset>
                <fieldset>
                    <button name='submit' type='submit' id='cwm-submit-btn'>Let's connect</button>
                </fieldset>
            </form>
        </div>
    </div>
  );
};

export default Footer;