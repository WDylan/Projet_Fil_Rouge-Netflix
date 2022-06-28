import React from 'react';
// import './NavBar.scss';
import './NavBar.css';

const NavBar = () => {
    return (
        <div className='nav'>
            <img src='./img/logo.png' className='brandLogo' alt='Netflix' href='/' />
            <div class="btn-group" role="group">
            </div>
            <button type="button" class="btn btn-danger">S'identifier</button>
        </div >

    );
};


export default NavBar;