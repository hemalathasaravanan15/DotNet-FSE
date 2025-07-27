// src/App.js
import React from 'react';
import CohortDetails from './CohortDetails';

function App() {
  return (
    <div>
      <CohortDetails title="React Bootcamp" status="ongoing" />
      <CohortDetails title="JavaScript Essentials" status="completed" />
    </div>
  );
}

export default App;
