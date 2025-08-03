import React from "react";
import ListOfPlayers from "./components/ListOfPlayers";
import ScoreBelow70 from "./components/ScoreBelow70";
import {
  OddPlayers,
  EvenPlayers,
  MergedPlayersList,
  IndianPlayersList,
} from "./components/IndianPlayers";

const App = () => {
  const flag = true;

  const players = [
    { name: "Virat", score: 85 },
    { name: "Rohit", score: 90 },
    { name: "Rahul", score: 65 },
    { name: "Gill", score: 78 },
    { name: "Pant", score: 88 },
    { name: "Hardik", score: 58 },
    { name: "Jadeja", score: 72 },
    { name: "Ashwin", score: 67 },
    { name: "Bumrah", score: 80 },
    { name: "Shami", score: 69 },
    { name: "Surya", score: 95 },
  ];

  const IndianTeam = IndianPlayersList; 

  if (flag === false) {
    return (
      <div>
        <h1>List of Players</h1>
        <ListOfPlayers players={players} />
        <hr />
        <h1>List of Players having Scores Less than 70</h1>
        <ScoreBelow70 players={players} />
      </div>
    );
  } else {
    return (
      <div>
        <h1>Indian Team</h1>

        <h2>Odd Players</h2>
        <OddPlayers players={IndianTeam} />

        <hr />

        <h2>Even Players</h2>
        <EvenPlayers players={IndianTeam} />

        <hr />

        <h2>List of Indian Players Merged:</h2>
        <MergedPlayersList players={IndianTeam} />
      </div>
    );
  }
};

export default App;
