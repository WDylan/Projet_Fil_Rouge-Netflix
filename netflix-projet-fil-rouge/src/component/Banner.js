import React from 'react'
import "./Banner.scss"
import PlayArrowIcon from '@mui/icons-material/PlayArrow';
import HelpOutlineIcon from '@mui/icons-material/HelpOutline';

function Banner() {

    return (
        <header className='banner'>
            <div className='banner__content'>
                <h1 className='banner__title'>Titre</h1>
                <p className='banner__description'>
                    Lorem ipsum dolor sit, amet consectetur adipisicing elit. Error ipsum
                    dolore nobis tempore nisi provident modi.
                </p>
                <div className='banner__buttons'>
                    <button className='banner__button banner__button--play'>
                        <PlayArrowIcon /> Lecture
                    </button>
                    <button className='banner__button'>
                    <HelpOutlineIcon /> Plus d'infos</button>
                </div>

            </div>
        </header>
    )
}

export default Banner