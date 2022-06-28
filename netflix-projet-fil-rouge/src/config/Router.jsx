import React from 'react';
import {
    BrowserRouter,
    Routes,
    Route,
    Outlet,
} from 'react-router-dom';
import Login from "../Views/SignInView/SignIn"
import SignUp from "../Views/SignUp/SignUp"


const Router = () => {
    return (
        <div>
            <BrowserRouter>
                <Routes>
                    <Route path='./login' element={<Login />} />
                    <Route path='./signup' element={<SignUp />} />
                </Routes>
            </BrowserRouter>
            <Outlet />
        </div>
    );
};






export default Router;