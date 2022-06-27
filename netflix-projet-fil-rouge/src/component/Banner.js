import React, { useState, useEffect } from 'react'
import "./Banner.scss"
import PlayArrowIcon from '@mui/icons-material/PlayArrow';
import HelpOutlineIcon from '@mui/icons-material/HelpOutline';
import requests from '../config/Requests.js';
import axios from 'axios';



function Banner() {
    const [movie, setMovie] = useState([]);

    useEffect(() => {
        async function fetchData() {
            const request = await axios.get(requests.fetchTrending);

            setMovie(
                request.data.results[
                Math.floor(Math.random() * request.data.results.length - 1)
                ]
            );
        }
        fetchData();
    }, []);

    function cacheText(string, i) {
        return string?.length > i ? string.substr(0, i - 1)
            + "..." : "Pas de description";
    }
    console.log(movie)

    const backgroundStyle = {
        backgroundImage: `url("https://image.tmdb.org/t/p/original/${movie.backdrop_path}")`,
        backgroundSize: "cover",
        bakcgroundPosition: "center center",
    };


    return (
        <header className='banner' style={backgroundStyle}>
            <div className='banner__content'>
                <h1 className='banner__title'>
                    {movie?.title || movie?.name || movie?.original_title}
                </h1>
                <p className='banner__description'>
                    {movie?.overview || cacheText(movie?.overview, 100)}
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