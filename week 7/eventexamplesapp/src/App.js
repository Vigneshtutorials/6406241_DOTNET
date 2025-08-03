import React from "react";
import Counter from "./components/Counter";
import CurrencyConvertor from "./components/CurrencyConvertor";

function App() {
  return (
    <div>
      <h1 style={{ textAlign: "center" }}>Event Handling Examples</h1>
      <Counter />
      <CurrencyConvertor />
    </div>
  );
}

export default App;
