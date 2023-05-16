import React from 'react';
import { BrowserRouter,Routes,Route } from "react-router-dom";
import Home from './Home';
import Registration from './Registration';
import About from './About';
import Work from './Work';
import Gallery from './Gallery';
import Contact from './Contact';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route exact path ='/' Component ={Home}/>
        <Route path ='/Home' Component={Home}/>
        <Route path ='/Registration' Component={Registration}/>
        <Route path ='/About' Component={About}/>
        <Route path ='/Work' Component={Work}/>
        <Route path ='/Gallery' Component={Gallery}/>
        <Route path ='/Contact' Component={Contact}/>
      </Routes>
    </BrowserRouter>
  );
}
//To activate the db.json: run the code npx json-server --watch db.json --port 8000
export default App;