import './App.scss';
import React from "react";
import {
  BrowserRouter,
  Route,
  Routes,
  Link,
  Outlet
} from 'react-router-dom';
import HomeScreen from './Views/HomeScreen/HomeScreen';
import LoginScreen from './Views/SignInView/LoginScreen'
import SignUpScreen from './Views/SignUp/SignUpScreen';
import { Home } from '@mui/icons-material';


function App() {
  return (
    <div>
    <div className='app'>
      <BrowserRouter>
        <Routes>
          <Route path="/Home" element={<HomeScreen />} />
          <Route path="/Connexion" element={<SignUpScreen />} />
          <Route path="/" exact  element={<LoginScreen />} />
        </Routes>
      </BrowserRouter>
    </div>
    </div>
  )
}

export default App;
