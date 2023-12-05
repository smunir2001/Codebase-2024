import React from 'react';
import './Skills.css';
import SkillsCard from './SkillsCard/SkillsCard';
import { FaCode } from "react-icons/fa";
import { FaCodepen } from "react-icons/fa";
import { FaCodeBranch } from "react-icons/fa6";
import { FaHtml5 } from "react-icons/fa";
import { FaCss3 } from "react-icons/fa";
import { FaReact } from "react-icons/fa";
import { IoLogoFirebase } from "react-icons/io5";
import { SiMongodb } from "react-icons/si";
import { SiFlask } from "react-icons/si";
import { TbBrandVscode } from "react-icons/tb";
import { FaGithub } from "react-icons/fa";
import { SiIntellijidea } from "react-icons/si";

const Skills = () => {
    const skillsCards = [
        {
            key: 1,
            icon: <FaCode/>,
            title: 'Front-end',
            info: 'I value simple content structure, clean design patterns, and thoughtful interactions.',
            skills: [
                {
                    key: 1,
                    name: 'HTML5',
                    icon: <FaHtml5/>,
                },
                {
                    key: 2,
                    name: 'CSS3',
                    icon: <FaCss3/>,
                },
                {   
                    key: 3,
                    name: 'ReactJS',
                    icon: <FaReact/>,
                }
            ]
        },
        {
            key: 2,
            icon: <FaCodeBranch/>,
            title: 'Back-end',
            info: 'I like to code things from scratch, and enjoy bringing ideas to life in the browser.',
            skills: [
                {
                    key: 1,
                    name: 'Flask',
                    icon: <SiFlask/>,
                },
                {
                    key: 2,
                    name: 'MongoDB',
                    icon: <SiMongodb/>,
                },
                {   
                    key: 3,
                    name: 'Firebase',
                    icon: <IoLogoFirebase/>,
                }
            ]
        },
        {
            key: 3,
            icon: <FaCodepen/>,
            title: 'Dev tools',
            info: 'I love using the latest and up-to-date developer tools to design and innovate impactful code.',
            skills: [
                {
                    key: 1,
                    name: 'Visual Studio Code',
                    icon: <TbBrandVscode/>,
                },
                {
                    key: 2,
                    name: 'GitHub',
                    icon: <FaGithub/>,
                },
                {   
                    key: 3,
                    name: 'IntelliJ Idea',
                    icon: <SiIntellijidea/>,
                }
            ]
        },
    ];
  return (
    <div className='skills-con'>
        <div className='skills-con-title-con'>
            <div className='skills-con-skills-card-con'>
                {
                    skillsCards.map((skillCard) =>
                        <SkillsCard 
                            key={skillCard.key}
                            icon={skillCard.icon}
                            title={skillCard.title}
                            info={skillCard.info}
                            skills={skillCard.skills}
                        />
                    )
                }
            </div>
        </div>
    </div>
  );
};

export default Skills;