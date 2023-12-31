import React from 'react';
import './HeroImg.css';
import { FaArrowRight } from "react-icons/fa";

const HeroImg = () => {
  return (
    <div className='heroImg-con'>
        <div className='heroImg-con-welcome-div'>
            <div className='heroImg-con-welcome-div-title-con'>
                <h1>Hi, I'm Sami!</h1>
            </div>
            <div className='heroImg-con-welcome-div-mssg-con'>
                <h2>A <span>Software</span> Engineer & <span>Full Stack</span> Developer</h2>
                <p>
                    As a Software Engineer and Web Developer, I have a
                    passion for working on full-stack applications and
                    embracing new challenges that allow me to stretch my
                    abilities. I thoroughly enjoy engaging with startup
                    environments and exploring advanced technologies. Let's
                    forge forces and innovate together!
                </p>
            </div>
            <div className='heroImg-con-welcome-div-cwm-con'>
                <button type='button'><div><span>Let's Connect</span><FaArrowRight/></div></button>
            </div>
        </div>
    </div>
  );
};

export default HeroImg;