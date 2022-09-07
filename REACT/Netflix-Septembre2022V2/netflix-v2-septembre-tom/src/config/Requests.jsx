// https://api.themoviedb.org/3/
// cle a91dc0c9fe60908a25c40d93c81008b7

const API_KEY = "a91dc0c9fe60908a25c40d93c81008b7";

const BASE_URL = "https://api.themoviedb.org/3/";

const requests = {
    fetchTrending: `${BASE_URL}/trending/all/week?api_key=${API_KEY}`,
    fetchNetflixOriginals: `${BASE_URL}/trending/all/week?api_key=${API_KEY}`,
    fetchTopRated: `${BASE_URL}/movie/top_rated?api_key=${API_KEY}&language=en-US`,
    fetchHorrorMovies: `${BASE_URL}/discover/movie?api_key=${API_KEY}&width_genres=10749`,
    fetchActionMovies: `${BASE_URL}/discover/movie?api_key=${API_KEY}&width_genres=28`,
}

export default requests;