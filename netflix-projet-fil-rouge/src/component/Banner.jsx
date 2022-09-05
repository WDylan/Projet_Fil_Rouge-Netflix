import React, { useState, useEffect } from 'react'
import "./Banner.scss"
import PlayArrowIcon from '@mui/icons-material/PlayArrow';
import InfoIcon from '@mui/icons-material/Info';
import VolumeUpIcon from '@mui/icons-material/VolumeUp';
import VolumeOffIcon from '@mui/icons-material/VolumeOff';
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

    function truncate(string, n) {
        return string?.length > n ? string.substr(0, n - 1) + "..." : string;
    }


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
                    {truncate(movie?.overview, 150)}
                </p>
                <div className='banner__buttons'>
                    <button className='banner__button banner__button--play'>
                        <PlayArrowIcon /> Lecture</button>
                    <button className='banner__button'>
                        <InfoIcon /> Plus d'infos</button>
                    <button className='banner__button banner__button--volume' onClick="changeButton">
                        <VolumeUpIcon /> 
                    </button>
                </div>
            </div>
        </header>
    )
}

export default Banner