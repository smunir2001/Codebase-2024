import React from 'react';
import './SkillsCard.css';

const SkillsCard = (props) => {
    const skills = props.skills;
  return (
    <div className='skillsCard-con'>
        <h1>{props.icon}</h1>
        <h2>{props.title}</h2>
        <p>{props.info}</p>
        <ul>
            {
                skills.map((skill) =>
                    <li key={skill.key}><div>{skill.name}<span>{skill.icon}</span></div></li>
                )
            }
        </ul>
    </div>
  );
};

export default SkillsCard;