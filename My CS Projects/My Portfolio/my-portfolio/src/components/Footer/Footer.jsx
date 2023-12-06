import React from 'react';
import './Footer.css';

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
        </div>
        <div className='footer-con-col2'>
            <form>
                <label for='email'>Email</label>
                <input type='text' id='email' name='email' placeholder='Your email'/>
                <br></br>
                <label for='cwm-mssg'>Send a message</label>
                <input type='text' id='cwm-mssg' name='cwm-mssg' placeholder="Let's connect..."/>
            </form>
        </div>
    </div>
  );
};

export default Footer;