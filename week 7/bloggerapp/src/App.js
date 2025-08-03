import React from "react";
import "./App.css";
import BookDetails from "./components/BookDetails";
import BlogDetails from "./components/BlogDetails";
import CourseDetails from "./components/CourseDetails";

const books = [
  { id: 101, bname: "Master React", price: 670 },
  { id: 102, bname: "Deep Dive into Angular 11", price: 800 },
  { id: 103, bname: "Mongo Essentials", price: 450 },
];

function App() {
  return (
    <div className="App">
      <div className="horizontal-layout">
        <div className="item">
          <BookDetails books={books} />
        </div>
        <div className="item">
          <BlogDetails />
        </div>
        <div className="item">
          <CourseDetails />
        </div>
      </div>
    </div>
  );
}

export default App;
