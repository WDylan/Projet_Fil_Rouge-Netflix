import React from "react";
import {
    BrowserRouter,
    Outlet,
    Routes,
    Route,
} from 'react-router-dom';
import SignIn from './Views/SignInView/SignIn';
import SignUp from './Views/SignUp/SignUp';
import SignUpFormScreen from "./Views/SignUpForm/SignUpFormScreen";


const Routers = () => {
    return (
        <div>
            <BrowserRouter>
                <Routes>
                    <Route path='/signin' element={<SignIn />} />
                    <Route path='/signup' element={<SignUp />} />
                    <Route path='/signupform' element={<SignUpFormScreen/>}/>
                </Routes>
            </BrowserRouter>
            <Outlet />
        </div>
    );
};

export default Routers;
