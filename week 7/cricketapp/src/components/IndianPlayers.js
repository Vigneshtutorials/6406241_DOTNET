import React from "react";

const T20Players = ["Sachin1", "Dhoni2", "Virat3"];
const RanjiTrophyPlayers = ["Rohit4", "Yuvaraj5", "Raina6"];
export const IndianPlayersList = [...T20Players, ...RanjiTrophyPlayers];

export function OddPlayers({ players }) {
  const [first, , third, , fifth] = players;
  return (
    <ul>
      <li>First: {first}</li>
      <li>Third: {third}</li>
      <li>Fifth: {fifth}</li>
    </ul>
  );
}

export function EvenPlayers({ players }) {
  const [, second, , fourth, , sixth] = players;
  return (
    <ul>
      <li>Second: {second}</li>
      <li>Fourth: {fourth}</li>
      <li>Sixth: {sixth}</li>
    </ul>
  );
}

export function MergedPlayersList({ players }) {
  return (
    <ul>
      {players.map((player, index) => (
        <li key={index}>Mr. {player}</li>
      ))}
    </ul>
  );
}
