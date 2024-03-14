import React from 'react';
import './App.css';
import Header from './Header';
import BowlingList from './Bowling/BowlingList';

function App() {
  return (
    <div className="App">
      <Header title="List of Bowlers" />
      <BowlingList />
    </div>
  );
}

export default App;
