import React from 'react'
import { useState } from 'react';
import "./Nav.scss";



function Nav() {

    const [navBlack, setNavBlack] = useState(false);
    const [toggleMenu, setToggleMenu] = useState(false);

    const transitionNav = () => {
        window.scrollY > 100 ? setNavBlack(true) : setNavBlack(false);
    };

    useState(() => {
        document.addEventListener("scroll", transitionNav);
    });

    const handleClick = () => {
        console.log(toggleMenu)
        toggleMenu ? setToggleMenu(false) : setToggleMenu(true);
    }



    return (
        <div className={`nav ${navBlack || toggleMenu ? "nav-black" : "nav-transparent"} ${toggleMenu && "show"}`}>

            <img src="./images/logo.png" className='nav_logo' alt="Netflix" />

            <div className="nav_actions">
                <a href="/" className="nav_action">
                    <button className='btn' onClick={handleClick}>S'identifier</button>
                </a>
            </div>
        </div>
    )
}

export default Nav