import React, {Component} from 'react';
import './Login.styles.css';

class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            username: '',
            password: '',
            error: null,
            showPassword: false, // State variable to control password show/hide
        };

    // Stored username & password
    this.validUsername = 'sambreezy';
    this.validPassword = 'sami123';
    }

    handleInputChange = (event) => {
        const {name, value} = event.target;
        this.setState({[name]: value});
    };

    handleFormSubmit = (event) => {
        event.preventDefault();
        const {username, password} = this.state;
        if (username === this.validUsername && password === this.validPassword) {
            /*
                Authentication succesful
                - set a state variable or take some action
                - redirect user or show successful login mssg or screen
            */
           alert('Login successful!')
           this.setState({error: null}); // Clear any previous errors
        } else {
            // Authentication failed
            // alert('Login failed. Please try again.')
            this.setState({error: 'Invalid username or password.'});
        }
    };

    render() {
        return (
            <div className='login-container'>
                <h2 className='login-title'>Login</h2>
                {this.state.error && <div className='error'>{this.state.error}</div>}
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
                            type={this.state.showPassword ? 'text' : 'password'}
                            name='password'
                            value={this.state.password}
                            onChange={this.handleInputChange}
                        />
                        <button
                            className='pw-toggle-btn' 
                            type='button'
                            onClick={() =>
                                this.setState({showPassword: !this.state.showPassword})
                            }
                        >
                            {this.state.showPassword ? 'Hide' : 'Show'}
                        </button>
                    </div>
                    <button type='submit' className='login-btn'>Login</button>
                </form>
            </div>
        );
    }
}

export default Login;