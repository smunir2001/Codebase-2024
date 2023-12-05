import {React, useState} from 'react';
import './App.css';
import TaskList from './components/TaskList/TaskList';

const App = () => {
    const [tasks, setTasks] = useState([
        {id: 1, text: 'Math homework'},
        {id: 2, text: 'English essay'},
    ]);

    const addTask = (text) => {
        setTasks([...tasks, {id: tasks.length + 1, text}]);
    };

    const deleteTask = (id) => {
        setTasks(tasks.filter((task) => task.id !== id));
    }

    return (
        <div className='App'>
            <h1>Homework Planner</h1>
            <TaskList task={tasks} onDelete={deleteTask}/>
            <input
                type='text'
                placeholder='Add new task'
                onKeyDown={(e) => {
                    if (e.key === 'Enter' && e.target.value.trim() !== '') {
                        addTask(e.target.value.trim());
                        e.target.value = '';
                    }
                }}
            />
        </div>
    );
};

export default App;