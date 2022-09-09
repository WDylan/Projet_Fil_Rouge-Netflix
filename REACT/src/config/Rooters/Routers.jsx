import React from "react";
import {
    BrowserRouter,
    Outlet,
    Routes,
    Link,
    Route,
} from 'react-router-dom';
import HomeScreen from '../../Views/HomeScreen/HomeScreen';
import LoginScreen from '../../Views/SignInView/LoginScreen'



const Routers = () => {
    return (
        <div>
            <BrowserRouter>
                <Link to="/">Home</Link>
                <Link to="/films">Films</Link>
                <Link to="/series">Series</Link>
                <Link to="/users">Utilisateurs</Link>
                <Link to="/home">HomeScreen</Link>
                <Link to="/login">LoginScreen</Link>

                <Routes>
                    <Route path="/login" element={<LoginScreen/>} /> 
                    <Route path="/home" element={<HomeScreen/>} /> 
                    <LoginScreen />
                </Routes>
            </BrowserRouter>
            <Outlet />
        </div>
    );
};

export default Routers;
