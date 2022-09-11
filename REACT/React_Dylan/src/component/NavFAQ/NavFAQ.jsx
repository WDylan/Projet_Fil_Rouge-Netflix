import React from 'react'
import { useState } from 'react'
import '../NavFAQ/NavFAQ.scss'

function NavFAQ() {

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
            <img src="/img/logo.png" className='nav_logo' alt="Netflix" />

            <div className="nav_actions">
                <a href="/" classname="nav_action">
                    <button className="btn" onClick={handleClick}>S'identifier</button>
                </a>
            </div>

        </div>
    )
}

export default NavFAQ