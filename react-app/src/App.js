import React from 'react';
import './App.css';
import { Route, Switch } from 'react-router-dom';
import Header from './components/header/header.component';
import HomePage from './pages/homepage/homepage.component';
function App() {
  return (
    <div className="App">
      <Header />
      <Switch>
      <Route exact path='/' component={HomePage} />

      </Switch>
    </div>
  );
}

export default App;
