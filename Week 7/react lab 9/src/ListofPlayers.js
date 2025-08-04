// src/ListofPlayers.js
import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Rohit', score: 80 },
    { name: 'Virat', score: 90 },
    { name: 'Gill', score: 65 },
    { name: 'Dhoni', score: 85 },
    { name: 'Pant', score: 45 },
    { name: 'Hardik', score: 75 },
    { name: 'Jadeja', score: 88 },
    { name: 'Bumrah', score: 50 },
    { name: 'Shami', score: 68 },
    { name: 'KL Rahul', score: 92 },
    { name: 'Surya', score: 55 }
  ];

  // Players with score < 70 (using arrow + filter)
  const lowScorers = players.filter(player => player.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      <ul>
        {players.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>

      <h3>Players with score below 70</h3>
      <ul>
        {lowScorers.map((player, index) => (
          <li key={index}>{player.name} - {player.score}</li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
