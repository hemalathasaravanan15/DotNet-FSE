import React, { Component } from 'react';
import CurrencyConverter from './CurrencyConverter';

class App extends Component {
  constructor() {
    super();
    this.state = {
      count: 0
    };
  }

  increment = () => {
    this.setState({ count: this.state.count + 1 });
    this.sayHello();
  };

  decrement = () => {
    this.setState({ count: this.state.count - 1 });
  };

  sayHello = () => {
    console.log('Hello from React Event Example!');
  };

  sayWelcome = (msg) => {
    alert(msg);
  };

  handleClick = (e) => {
    console.log(e); // synthetic event
    alert('I was clicked');
  };

  render() {
    return (
      <div style={{ padding: '30px', fontFamily: 'Arial' }}>
        <h1>React Event Handling Example</h1>

        <h2>Counter: {this.state.count}</h2>

        <button onClick={this.increment}>Increment</button>
        &nbsp;
        <button onClick={this.decrement}>Decrement</button>

        <br /><br />

        <button onClick={() => this.sayWelcome('Welcome to the Event App!')}>Say Welcome</button>

        <br /><br />

        <button onClick={this.handleClick}>Synthetic Event (OnPress)</button>

        <br /><br />

        <CurrencyConverter />
      </div>
    );
  }
}

export default App;
