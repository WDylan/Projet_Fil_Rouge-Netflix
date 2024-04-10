import "./Films.scss"
import React, { useState } from "react";
import {
    getFilmsApi,
    searchFilmsApi,
    postFilmsApi,
    updateFilmsApi,
    deleteFilmsApi,
} from '../../ApiService';



const FilmsList = () => {

    /**
     *  States
     */
    const [filmsList, setFilmsList] = useState(() => FetchData());

    /**
     *  Function
     */

    function FetchData() {
        getFilmsApi().then((data) => {
            console.log(data);
            setFilmsList(data)
        })
    }

    // Add 
    function AddFilms(titre, genre, duree, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video) {
        alert(`titre : ${titre} - genre : ${genre} - duree : ${duree} - datesortie - ${datesortie} - synopsis : ${synopsis} - acteur_nom : ${acteur_nom} - realisateur_nom : ${realisateur_nom} - recommandation : ${recommandation} - image : ${image} - video : ${video}`);
        postFilmsApi({ titre, genre, duree, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video });
    }

    // Update
    function UpdateFilms(idfilm, titre, genre, duree, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video) {
        // eslint-disable-next-line no-restricted-globals
        let response = confirm(`Voulez-vous vraiment modifier le film n°${idfilm} ?`)
        if (response)
        updateFilmsApi({idfilm, titre, genre, duree, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video});
    }

    // Delete
    function DeleteFilms(idFilms) {
        // eslint-disable-next-line no-restricted-globals
        let response = confirm(`Voulez-vous vraiment supprimer ce film n°${idFilms}`)
        if (response)
        deleteFilmsApi(idFilms).then(() => FetchData());
    }

    return (
        <div>
        </div>
    );
};
export default Films;