const _BASE_URL = "http://localhost:5191/api";
const _HEADERS = {
    'Accept': 'application/json',
    'Content-Type': 'application/json'
}


// Méthode Films
export const getFilmsApi = async () => {
    const reponse = await fetch(_BASE_URL + "/films")
        .then((res) =>
            res.json()
        )
    return reponse.data
}

export const searchFilmsApi = async (IdFilm) => {
    const reponse = await fetch(_BASE_URL + '/films' + IdFilm)
        .then((res) =>
            res.json()
        );
    return reponse.data;
}

export const postFilmsApi = (async (Films) => {
    alert(`Titre : ${Films.Genre} - Genre : ${Films.Genre} - Durée : ${Films.Duree} minutes - Date de sortie : ${Films.DateSortie} </br>
    Synopsis : ${Films.Synopsis} </br> 
    Acteur(s) : ${Films.Acteur_Nom} - Réalisateur : ${Films.Realisateur_Nom} - Recommandation : ${Films.Recommandation}</br>
    ${Films.Image} - ${Films.Video}`);
    const rawResponse = await fetch(_BASE_URL + '/films', {
        method: 'POST',
        headers: _HEADERS,
        body: JSON.stringify({
            titre: Films.titre,
            genre: Films.genre,
            duree: Films.duree,
            gedatedesortie: Films.datesortie,
            synopsis: Films.synopsis,
            acteur_nom: Films.acteur_nom,
            realisateur_nom: Films.realisateur_nom,
            recommandation: Films.recommandation,
            image : Films.image,        
            video : Films.video,        
        })
    })
    const Content = await rawResponse.json();
    console.log("POST Response : " + Content);
    return Content;
});


export const updateFilmsApi = (async (Films) => {
    const rawResponse = await fetch(_BASE_URL + '/films/' + Films.IdFilm, {
        method: 'PUT',
        headers: _HEADERS,
        body: JSON.stringify({
            titre: Films.titre,
            genre: Films.genre,
            duree: Films.duree,
            gedatedesortie: Films.datesortie,
            synopsis: Films.synopsis,
            acteur_nom: Films.acteur_nom,
            realisateur_nom: Films.realisateur_nom,
            recommandation: Films.recommandation,
            image : Films.image,        
            video : Films.video,       
        })
    })
    const Content = await rawResponse.json();
    console.log("UPDATE Response : " + Content);
    return Content;
});

export const deleteFilmsApi = (async (FilmsId) => {
    const rawResponse = await fetch(_BASE_URL + '/films/' + FilmsId, {
        method: 'DELETE',
        headers: _HEADERS
    });
    const Content = await rawResponse.json();
    console.log("DELETE Response : " + Content);
    return Content;
});


// Methode Séries
export const getSeriesApi = async () => {
    const reponse = await fetch(_BASE_URL + "/series")
        .then((res) =>
            res.json()
        )
    return reponse.data
}

export const searchSeriesApi = async (IdSerie) => {
    const reponse = await fetch(_BASE_URL + '/series' + IdSerie)
        .then((res) =>
            res.json()
        );
    return reponse.data;
}

export const postSeriesApi = (async (Series) => {
    alert(`Titre : ${Series.Genre} - Genre : ${Series.Genre} - Episodes : ${Series.NbEpisodes} - Date de sortie : ${Series.DateSortie} </br>
    Synopsis : ${Series.Synopsis} </br> 
    Acteur(s) : ${Series.Acteur_Nom} - Réalisateur : ${Series.Realisateur_Nom} - Recommandation : ${Series.Recommandation}</br>
    ${Series.Image} - ${Series.Video}`);
    const rawResponse = await fetch(_BASE_URL + '/series', {
        method: 'POST',
        headers: _HEADERS,
        body: JSON.stringify({
            titre: Series.titre,
            genre: Series.genre,
            nbepisodes: Series.duree,
            gedatedesortie: Series.datesortie,
            synopsis: Series.synopsis,
            acteur_nom: Series.acteur_nom,
            realisateur_nom: Series.realisateur_nom,
            recommandation: Series.recommandation,  
            image : Series.image,
            video : Series.video     
        })
    })
    const Content = await rawResponse.json();
    console.log("POST Response : " + Content);
    return Content;
});


export const updateSeriesApi = (async (Series) => {
    const rawResponse = await fetch(_BASE_URL + '/series/' + Series.IdSerie, {
        method: 'PUT',
        headers: _HEADERS,
        body: JSON.stringify({
            titre: Series.titre,
            genre: Series.genre,
            nbepisodes: Series.duree,
            gedatedesortie: Series.datesortie,
            synopsis: Series.synopsis,
            acteur_nom: Series.acteur_nom,
            realisateur_nom: Series.realisateur_nom,
            recommandation: Series.recommandation,  
            image : Series.image,
            video : Series.video      
        })
    })
    const Content = await rawResponse.json();
    console.log("UPDATE Response : " + Content);
    return Content;
});

export const deleteSeriesApi = (async (IdSerie) => {
    const rawResponse = await fetch(_BASE_URL + '/series/' + IdSerie, {
        method: 'DELETE',
        headers: _HEADERS
    });
    const Content = await rawResponse.json();
    console.log("DELETE Response : " + Content);
    return Content;
});

