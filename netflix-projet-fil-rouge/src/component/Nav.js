import React from 'react';
import { useState } from 'react';
import "./Nav.scss";
import MenuIcon from '@mui/icons-material/Menu';
import SearchIcon from '@mui/icons-material/Search';
import CardGiftcardIcon from '@mui/icons-material/CardGiftcard';
import NotificationsIcon from '@mui/icons-material/Notifications';


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
        <div className={`nav ${navBlack || toggleMenu ? "nav--black" : "nav--transparent"} 
        ${toggleMenu && "show"}`}>
            <button className='nav__burger' onClick={handleClick}>
                <MenuIcon />
            </button>
            <img src='./img/logo.png' className='nav__logo' alt='Netflix'/>
            <nav className="nav__links">
                <a href='/' className='nav__link'>
                    Accueil
                </a>
                <a href='/' className='nav__link'>
                    Séries
                </a>
                <a href='/' className='nav__link'>
                    Films
                </a>
            </nav>
            <div className='nav__actions'>
                <a href='/' className='nav__action'>
                    <SearchIcon />
                </a>
                <a href='/' className='nav__action'>
                    Direct
                </a>
                <a href='/' className='nav__action'>
                    <CardGiftcardIcon />
                </a>
                <a href='/' className='nav__action'>
                    <NotificationsIcon />
                </a>
                <a href='/' className='nav__action'>
                    <img className='nav__avatar' src='./img/Netflix-avatar.png' />
                </a>
            </div>
        </div>
    )
}

export default Nav;