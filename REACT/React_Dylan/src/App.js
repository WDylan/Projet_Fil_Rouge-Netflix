import './App.scss';
import React from "react";
import {
  BrowserRouter,
  Route,
  Routes,
} from 'react-router-dom';
import HomeScreen from './Views/HomeScreen/HomeScreen';
import LoginScreen from './Views/SignInView/LoginScreen'
import SignUpFormScreen from './Views/SignUpForm/SignUpFormScreen'
import SignUpScreen from './Views/SignUp/SignUpScreen'
import { Home } from '@mui/icons-material';
import FAQ from './Views/FAQ/FAQ';
// import Login from './Views/SignInView/SignIn';

function App() {
  const user = null;

  return (
    <div className='app'>
      <BrowserRouter>
        <Routes>
          <Route path="/Home" element={<HomeScreen />} />
          <Route path="/Connexion" element={<SignUpScreen />} />
          <Route path="/Formulaire" element={<SignUpFormScreen />} />
          <Route path="/" element={<FAQ />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
