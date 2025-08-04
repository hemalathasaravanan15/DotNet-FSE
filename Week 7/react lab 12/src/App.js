import React, { useState } from 'react';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const flightDetails = {
    from: 'Chennai',
    to: 'Delhi',
    date: '2025-08-10',
    price: '₹5000'
  };

  // Element variable based on login
  let content;
  if (isLoggedIn) {
    content = (
      <div>
        <h2>Welcome, User!</h2>
        <p><strong>Flight:</strong> {flightDetails.from} → {flightDetails.to}</p>
        <p><strong>Date:</strong> {flightDetails.date}</p>
        <p><strong>Price:</strong> {flightDetails.price}</p>
        <button>Book Ticket</button>
      </div>
    );
  } else {
    content = (
      <div>
        <h2>Welcome, Guest!</h2>
        <p>You can browse available flights below:</p>
        <p><strong>Flight:</strong> {flightDetails.from} → {flightDetails.to}</p>
        <p><strong>Date:</strong> {flightDetails.date}</p>
        <p><strong>Price:</strong> {flightDetails.price}</p>
        <p><em>Please login to book your ticket.</em></p>
      </div>
    );
  }

  return (
    <div style={{ padding: '30px', fontFamily: 'Arial' }}>
      <h1>Flight Ticket Booking App</h1>
      <button onClick={() => setIsLoggedIn(!isLoggedIn)}>
        {isLoggedIn ? 'Logout' : 'Login'}
      </button>

      <hr />
      {content}
    </div>
  );
}

export default App;
