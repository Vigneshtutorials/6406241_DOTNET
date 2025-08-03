import React from "react";

function ScoreBelow70({ players }) {
  const filtered = players.filter((p) => p.score <= 70);
  return (
    <ul>
      {filtered.map((player, index) => (
        <li key={index}>
          Mr. {player.name} - <span>{player.score}</span>
        </li>
      ))}
    </ul>
  );
}

export default ScoreBelow70;
