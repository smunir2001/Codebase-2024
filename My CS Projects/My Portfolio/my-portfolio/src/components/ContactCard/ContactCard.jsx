import React from 'react';
import './ContactCard.css';
import ContactCardImg from '../../assets/contact-card-img.jpg';
// import { FaInstagram } from "react-icons/fa";

const ContactCard = () => {
  return (
    <div className='contact-card-con'>
        <div className='contact-card-con-img-con'>
            <img src={ContactCardImg} alt='contact-img'/>
        </div>
        <div className='contact-card-con-text-con'>
            <h3>Sami Munir</h3>
            <h4>smunir2001@gmail.com</h4>
        </div>
    </div>
  );
};

export default ContactCard;