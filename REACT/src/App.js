import './App.scss';
import React from "react";
import {
  BrowserRouter,
  Route,
  Routes,
} from 'react-router-dom';
import HomeScreen from './Views/HomeScreen/HomeScreen';
import LoginScreen from './Views/SignInView/LoginScreen'
import { Home } from '@mui/icons-material';
import FilmsList from './Views/HomeScreenListView/FilmsList';
import SeriesList from './Views/HomeScreenListView/SeriesList';
import Rooter from './config/Rooters/Routers';


function App() {
  const user = null;
  //   { 
  // name : "test",
  //   };
  return (
    <div className='app'>
<Rooter/>
    </div>
  );
}

export default App;
