import React from 'react';
import "./Nav-Main.scss";
import SignUp from '../Views/SignUp/SignUp';

function NavMain() {

    return (
        <div className='nav'>
            <img src='./img/logo.png' className='nav__logo' />

            <button className="loginButton">S'identifier</button>

        </div>
    );
};

export default NavMain;


{/* <Link className="formButton" to='/login'>Sign Up</Link>

<div className='span'>Already a user?</div>

<Link className="formButton2" to= '/login'>Sign in now!</Link> */}