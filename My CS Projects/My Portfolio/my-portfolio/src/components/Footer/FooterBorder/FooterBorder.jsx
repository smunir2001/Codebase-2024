import React from 'react';
import './FooterBorder.css';
import { FaCopyright } from "react-icons/fa";

const FooterBorder = () => {
  return (
    <div className='footer-border-con'>
        <p>Sami Munir <span><FaCopyright/></span></p>
    </div>
  );
};

export default FooterBorder;