import './App.scss';
import React, { Component } from "react";
import {
    BrowserRouter,
    Router,
    Routes,
} from 'react-router-dom';
import LoginScreen from './Views/LoginScreen/LoginScreen'
import HomeScreen from './Views/HomeScreen/HomeScreen';


function App() {
    return (
        <BrowserRouter>
            <LoginScreen />
            <HomeScreen />
        </BrowserRouter>
    )
}

export default App;
