import React, { Component } from 'react';

class CurrencyConverter extends Component {
  constructor() {
    super();
    this.state = {
      rupees: '',
      euros: ''
    };
  }

  handleChange = (e) => {
    this.setState({ rupees: e.target.value });
  };

  handleSubmit = (e) => {
    e.preventDefault(); // prevent page reload
    const rate = 0.011; // 1 INR = 0.011 EUR (example rate)
    const euros = this.state.rupees * rate;
    this.setState({ euros: euros.toFixed(2) });
  };

  render() {
    return (
      <div style={{ marginTop: '30px' }}>
        <h2>Currency Converter: INR to EUR</h2>
        <form onSubmit={this.handleSubmit}>
          <input
            type="number"
            placeholder="Enter amount in INR"
            value={this.state.rupees}
            onChange={this.handleChange}
          />
          <button type="submit">Convert</button>
        </form>
        <p>Converted Amount in Euros: € {this.state.euros}</p>
      </div>
    );
  }
}

export default CurrencyConverter;
