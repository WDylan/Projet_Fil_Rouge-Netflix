import React from 'react';
// import './NavBar.scss';
import './NavBar.css';

const NavBar = () => {
    return (
        <div className='nav'>
            
            <img src='./img/logo.png' className='brandLogo' alt='Netflix' href='/' />
            <hr/>
            <div>
                <div class="btn-group" role="group">
                    <button id="btnGroupDrop1" type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Français
                    </button>
                    <div class="dropdown-menu" aria-labelledby="btnGroupDrop1">
                        <a class="dropdown-item" href="#">Français</a>
                        <a class="dropdown-item" href="#">English</a>
                    </div>
                </div>
                <button type="button" class="btn btn-danger">S'identifier</button>
            </div>
        </div >
        
    );
};


export default NavBar;