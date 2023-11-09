import React, {Component} from 'react';
import './Login.styles.css';

class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            username: '',
            password: '',
        };
    }

    handleInputChange = (event) => {
        const {name, value} = event.target;
        this.setState({[name]: value});
    };

    handleFormSubmit = (event) => {
        event.preventDefault();
        // Add logic here...
        console.log('Username: ', this.state.username);
        console.log('Password: ', this.state.password);
    };

    render() {
        return (
            <div className='login-container'>
                <h2 className='login-title'>Login</h2>
                <form onSubmit={this.handleFormSubmit}>
                    <div className='form-container' id='form-username-container'>
                        <label>Username:</label>
                        <input
                            type='text'
                            name='username'
                            value={this.state.username}
                            onChange={this.handleInputChange}    
                        />
                    </div>
                    <div className='form-container' id='form-password-container'>
                        <label>Password:</label>
                        <input
                            type='password'
                            name='password'
                            value={this.state.password}
                            onChange={this.handleInputChange}
                        />
                    </div>
                    <button type='submit' className='login-btn'>Login</button>
                </form>
            </div>
        );
    }
}

export default Login;