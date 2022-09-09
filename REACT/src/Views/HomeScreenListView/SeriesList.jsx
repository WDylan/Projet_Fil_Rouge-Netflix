import React, { useState } from "react";
import {
    getSeriesApi,
    searchSeriesApi,
    postSeriesApi,
    updateSeriesApi,
    deleteSeriesApi,
} from '../../ApiService';
import "./SeriesList.scss"


const SeriesList = () => {

    /**
     *   States
     */
     const [seriesList, setSeriesList] = useState(() => FetchData());

    /**
     *  Function
     */
    function FetchData() {
        getSeriesApi().then((data) => {
            console.log(data);
            setSeriesList(data)
        })
    }

    //Add 
    function AddSeries(titre, genre, nbepisodes, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video) {
        alert(`titre : ${titre} - genre : ${genre} - nbepisodes : ${nbepisodes} - datesortie - ${datesortie} - synopsis : ${synopsis} - acteur_nom : ${acteur_nom} - realisateur_nom : ${realisateur_nom} - recommandation : ${recommandation} - image : ${image} - video : ${video}`);
        postSeriesApi({ titre, genre, nbepisodes, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video });
    }

    // Update
    function UpdateSeries(idserie, titre, genre, nbepisodes, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video) {
        // eslint-disable-next-line no-restricted-globals
        let reponse = confirm(`Voulez-vous vraiment modifier cette série n°${idserie} ?`)
        if (reponse)
            updateSeriesApi({ idserie, titre, genre, nbepisodes, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video });
    }

    // Delete
    function DeleteSeries(idSerie) {
        // eslint-disable-next-line no-restricted-globals
        let reponse = confirm(`Voulez-vous vraiment supprimer cette série n°${idSerie} ?`)
        if (reponse)
        deleteSeriesApi(idSerie).then(() => FetchData());
    }

    return (
        <div>

        </div>
    )
}



export default SeriesList;