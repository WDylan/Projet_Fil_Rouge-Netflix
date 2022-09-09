import "./HomeScreenListView.scss"
import React, { useState } from "react";
import Nav from '../../component/Nav';
import Footer from '../../component/Footer';
import Banner from '../../component/Banner';
import '../../ApiService'


const Catalogue = () => 
{
    function AddFilms(titre, genre, duree, datesortie, synopsis, acteur_nom, realisateur_nom, recommandation, image, video)
    {

    }



    return (
        <div>
            <Nav />

            {/* Banner */}
            <Banner />

            {/* Row */}


            {/*Footer*/}
            <Footer/>
        </div>
    );
};
export default Catalogue;