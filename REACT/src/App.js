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
import Catalogue from './Views/HomeScreenListView/HomeScreenListView';
// import FAQ from './Views/FAQ/Faq'
// import Login from './Views/SignInView/SignIn';

function App() {
  const user = null;
//   { 
// name : "test",
//   };
  return (
    <div className='app'>
        <Catalogue/>
    </div>
  );
}

export default App;
