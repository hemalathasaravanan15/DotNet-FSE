import React from 'react';
import '../Stylesheets/mystyle.css';

function CalculateScore() {
  const name = "Hema";
  const school = "CTK Girls Matric Higher Secondary School";
  const total = 480;
  const goal = 500;

  const average = (total / goal) * 100;

  return (
    <div className="score-container">
      <h2>Student Score Details</h2>
      <p><strong>Name:</strong> {name}</p>
      <p><strong>School:</strong> {school}</p>
      <p><strong>Total Marks:</strong> {total}</p>
      <p><strong>Goal Marks:</strong> {goal}</p>
      <p><strong>Average Score:</strong> {average.toFixed(2)}%</p>
    </div>
  );
}

export default CalculateScore;
