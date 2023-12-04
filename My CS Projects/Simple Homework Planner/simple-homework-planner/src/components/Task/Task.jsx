import React from 'react';
import './Task.css';
import {FaTrash} from 'react-icons/fa';

const Task = ({task, onDelete}) => {
  return (
    <div className='Task'>
        <p>{task.text}</p>
        <button onClick={() => onDelete(task.id)}>
            <FaTrash/>
        </button>
    </div>
  );
};

export default Task;