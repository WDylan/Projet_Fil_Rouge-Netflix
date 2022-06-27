import React from 'react';
import "./Row.scss";
import { useEffect, useState } from 'react';
import axios from 'axios';

function Row(title, fetchUrl) {
    const [movies, setMovies] = useState([]);

    useEffect(() => {
        async function fetchData() {
            const request = await axios.get(fetchUrl);

            setMovies(
                request.data.results
            );
        }
        fetchData();
    }, [fetchUrl]);


    return (
        <div className='row'>
            <h2 className='row__title'></h2>
            <div className="row__images">
                {movies.map((movie) => <div key={movie.id}>
                    <img
                        src={`https://image.tmdb.org/t/p/original/${movie.backdrop_path}`}
                        className="row__image"
                        alt="{movie?.title || movie?.name || movie?.original_title}"/>
                </div>)}
            </div>


        </div>
    );
};

export default Row;