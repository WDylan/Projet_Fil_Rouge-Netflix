import "./Row.scss";
import { useEffect, useState } from 'react';
import axios from 'axios';

function Row({ title, fetchUrl, isPoster }) {
    const baseUrl = "https://image.tmdb.org/t/p/original/";
    const [movies, setMovies] = useState([]);

    useEffect(() => {
        async function fetchData() {
            const request = await axios.get(fetchUrl);
            setMovies(request.data.results)
            return request;
        }
        fetchData();
    }, [fetchUrl]);

    console.log(movies);


    return (
        <div className='row'>
            <h2 className='row__title'>{title}</h2>
            <div className='row__images'>
                {movies.map(movie => (
                    <div key={movie.id}>
                        {isPoster ? (
                            <img
                                src={`${baseUrl}${movie.poster_path}`}
                                className='row__image'
                                alt='{movie?.title || movie?.name || movie?.original_title}' />
                        ) : (
                            <img
                                src={`${baseUrl}${movie.backdrop_path}`}
                                className='row__image'
                                alt='{movie?.title || movie?.name || movie?.original_title}' />
                        )}
                    </div>
                ))}
            </div>
        </div>

    );
}

export default Row;