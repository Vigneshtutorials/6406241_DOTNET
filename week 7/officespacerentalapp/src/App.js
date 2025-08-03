import React from "react";
import OfficeCard from "./components/OfficeCard";

function App() {
  const officeList = [
    {
      name: "DBS",
      rent: 50000,
      address: "Chennai",
      image:
        "https://cdn.pixabay.com/photo/2015/04/20/06/46/office-730681_1280.jpg", // Replace with your own
    },
    {
      name: "Regus",
      rent: 75000,
      address: "Bangalore",
      image:
        "https://cdn.pixabay.com/photo/2017/03/28/12/11/chairs-2181960_1280.jpg",
    },
  ];

  return (
    <div style={{ textAlign: "center" }}>
      <h1>Office Space , at Affordable Range</h1>
      {officeList.map((item, index) => (
        <OfficeCard key={index} item={item} />
      ))}
    </div>
  );
}

export default App;
