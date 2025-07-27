import "./App.css";
import CalculateScore from "./components/CalculateScore";

function App() {
  return (
    <div className="App">
      <CalculateScore
        Name={"Vignesh"}
        School={"DNV Public School"}
        total={284}
        goal={3}
      />
    </div>
  );
}

export default App;
