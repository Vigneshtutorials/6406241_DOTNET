import React from "react";

function OfficeCard({ item }) {
  const rentStyle = {
    color: item.rent <= 60000 ? "red" : "green",
    fontWeight: "bold",
  };

  return (
    <div style={{ margin: "20px" }}>
      <img src={item.image} alt={item.name} width="200" height="200" />
      <h2>Name: {item.name}</h2>
      <p style={rentStyle}>Rent: Rs. {item.rent}</p>
      <p>
        <strong>Address:</strong> {item.address}
      </p>
    </div>
  );
}

export default OfficeCard;
