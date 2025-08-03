import React, { useState } from "react";

function CurrencyConvertor() {
  const [rupees, setRupees] = useState("");
  const [euro, setEuro] = useState(null);

  const handleChange = (e) => {
    setRupees(e.target.value);
  };

  const handleSubmit = () => {
    const euroValue = parseFloat(rupees) / 89; // Approx. 1 Euro = 89 INR
    setEuro(euroValue.toFixed(2));
  };

  return (
    <div style={{ textAlign: "center" }}>
      <h2>Currency Converter</h2>
      <input
        type="number"
        placeholder="Enter amount in INR"
        value={rupees}
        onChange={handleChange}
      />
      <button onClick={handleSubmit}>Convert</button>
      {euro && (
        <p>
          {rupees} INR = €{euro}
        </p>
      )}
    </div>
  );
}

export default CurrencyConvertor;
