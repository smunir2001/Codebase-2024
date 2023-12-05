import React from 'react';
import Task from '../Task/Task';

const TaskList = ({tasks, onDelete}) => {
  return (
    <div className='TaskList'>
      {
        tasks.map((task) => (
          <Task key={task.id} task={task} onDelete={onDelete}/>
        ))
      }
    </div>
  );
};

export default TaskList;