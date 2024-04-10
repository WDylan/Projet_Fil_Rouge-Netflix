import './App.scss';
import React, { Component } from "react";
import {
  BrowserRouter,
  Route,
  Routes,
} from 'react-router-dom';
import HomeScreen from './Views/HomeScreen/HomeScreen';
import SignInScreen from './Views/SignIn/SignInScreen';
import { Home } from '@mui/icons-material';
import { Series } from './Views/HomeScreenListView/Series';
import TestFAQ from './Views/TestFAQ/TestFAQ';
import LoginScreen from './Views/LoginScreen/LoginScreen';


function App() {
  return (

    <BrowserRouter>
        <LoginScreen />
    </BrowserRouter>

  )
}

export default App;
