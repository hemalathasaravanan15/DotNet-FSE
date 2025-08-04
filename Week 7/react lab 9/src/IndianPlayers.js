import React from 'react';

const IndianPlayers = () => {
  const allPlayers = ['Sachin1', 'Dhoni2', 'Virat3', 'Rohit4', 'Yuvaraj5', 'Raina6'];

  // Destructure players into odd and even index arrays
  const oddPlayers = allPlayers.filter((_, i) => i % 2 === 0);   // 0, 2, 4 => 1st, 3rd, 5th
  const evenPlayers = allPlayers.filter((_, i) => i % 2 !== 0);  // 1, 3, 5 => 2nd, 4th, 6th

  // Positional labels
  const positions = ['First', 'Second', 'Third', 'Fourth', 'Fifth', 'Sixth'];

  // Merged players
  const T20players = ['First Player', 'Second Player', 'Third Player'];
  const RanjiTrophyPlayers = ['Fourth Player', 'Fifth Player', 'Sixth Player'];
  const mergedPlayers = [...T20players, ...RanjiTrophyPlayers];

  return (
    <div>
      <h2>Odd Players</h2>
      <ul>
        {oddPlayers.map((player, index) => (
          <li key={index}>{positions[index * 2]} : {player}</li>
        ))}
      </ul>

      <h2>Even Players</h2>
      <ul>
        {evenPlayers.map((player, index) => (
          <li key={index}>{positions[index * 2 + 1]} : {player}</li>
        ))}
      </ul>

      <h2>List of Indian Players Merged:</h2>
      <ul>
        {mergedPlayers.map((player, index) => (
          <li key={index}>Mr. {player}</li>
        ))}
      </ul>
    </div>
  );
};

export default IndianPlayers;
