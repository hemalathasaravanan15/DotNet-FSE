import React from 'react';

function App() {
  // Single office object
  const office = {
    name: 'DBS',
    rent: 50000,
    address: 'Chennai',
    image: 'https://media.istockphoto.com/id/1396752048/photo/modern-office-building-interior.jpg?s=612x612&w=0&k=20&c=_a5rAzrzqRx29IEuXx7WSy2MOfKtL8Qdw-ZVVmx2BPM='
  };

  return (
    <div style={{ padding: '40px', fontFamily: 'Arial' }}>
      <h1 style={{ fontWeight: 'bold' }}>Office Space , at Affordable Range</h1>

      <img
        src={office.image}
        alt="Office"
        style={{ width: '300px', height: '200px', margin: '20px 0' }}
      />

      <h2>Name: {office.name}</h2>
      <p style={{ color: office.rent < 60000 ? 'red' : 'green', fontWeight: 'bold' }}>
        Rent: Rs. {office.rent}
      </p>
      <p><strong>Address:</strong> {office.address}</p>
    </div>
  );
}

export default App;
