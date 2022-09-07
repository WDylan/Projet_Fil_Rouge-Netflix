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
// import FAQ from './Views/FAQ/Faq'
// import Login from './Views/SignInView/SignIn';

function App() {
  const user = null;
//   { 
// name : "test",
//   };
  return (
    <div className='app'>
      <BrowserRouter>
        {!user ? (
          <LoginScreen />
        ) : (
          <Routes>
            <Route path="/Home" element={<HomeScreen/>}/>
          </Routes>
        )}
      </BrowserRouter>
    </div>
  );
}

export default App;
