import React from 'react';
import CourseDetails from './CourseDetails';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';

function App() {
  const columnStyle = {
    flex: 1,
    padding: '20px',
    borderRight: '4px solid green',
    fontFamily: 'Arial'
  };

  const lastColumnStyle = {
    ...columnStyle,
    borderRight: 'none'
  };

  return (
    <div style={{ display: 'flex', justifyContent: 'center' }}>
      <div style={columnStyle}><CourseDetails /></div>
      <div style={columnStyle}><BookDetails /></div>
      <div style={lastColumnStyle}><BlogDetails /></div>
    </div>
  );
}

export default App;
