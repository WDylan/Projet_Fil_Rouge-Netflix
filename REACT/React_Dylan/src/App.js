import './App.scss';
import React from "react";
import {
  BrowserRouter,
  Route,
  Routes,
} from 'react-router-dom';
import HomeScreen from './Views/HomeScreen/HomeScreen';
import SignUpForm from './Views/SignUpForm/SignUpForm';
import SignUpScreen from './Views/SignUp/SignUpScreen'
import FAQ from './Views/FAQ/FAQ';
import TestFAQ from './Views/TestFAQ/TestFAQ';

function App() {
  const user = null;

  return (
    <div className='app'>
      <BrowserRouter>
        <Routes>
          <Route path="/Home" element={<HomeScreen />} />
          <Route path="/Connexion" element={<SignUpScreen />} />          
          <Route path="/Formulaire" element={<SignUpForm />} />
          <Route path="/" element={<TestFAQ />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
