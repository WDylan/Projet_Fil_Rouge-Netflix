import React from 'react'
import { useState } from 'react'
import './/Style/AccordionFAQ.scss'
import { Fragment } from 'react';



const str1 = "Netflix est un service de streaming qui propose une vaste sélection de séries,films, animes, documentaires et autres programmes primés sur des milliers d'appareils connectés à Internet.\n\n Regardez tout ce que vous voulez, quand vous voulez, sans publicité et à un tarif mensuel très attractif. Découvrez de nouveaux films et séries chaque semaine, il y en a pour tous les goûts !";

const str3 = "Netflix, c'est où vous voulez, quand vous voulez. Connectez-vous à votre compte pour regarder Netflix en ligne sur netflix.com depuis votre ordinateur ou tout appareil connecté à Internet avec l'application Netflix, comme les Smart TV, smartphones, tablettes, lecteurs de streaming et consoles de jeu.\n\n Vous pouvez aussi télécharger vos séries préférées avec l'application iOS, Android ou Windows 10. Téléchargez des titres pour les regarder sur votre appareil mobile, même sans connexion Internet. Emportez Netflix partout avec vous.";

const str6 = "Netflix Jeunesse est inclus dans votre abonnement et offre un meilleur contrôle aux parents, ainsi qu'un espace dédié aux enfants, avec des films et des séries destinés à toute la famille.\n\n Les profils Jeunesse comportent des fonctionnalités de contrôle parental avec code PIN permettant de modifier la catégorie d'âge des contenus que vos enfants peuvent regarder et de bloquer des titres spécifiques.";

function Accordion({ title, content }) {


    const lines1 = str1.split(/\n/);
    const withBreaks1 = lines1.flatMap((line, index) =>
        index > 0
            ? [<br key={`br-${index}`} />, <Fragment key={index}>{line}</Fragment>]
            : [line]
    );

    const lines3 = str3.split(/\n/);
    const withBreaks3 = lines3.flatMap((line, index) =>
        index > 0
            ? [<br key={`br-${index}`} />, <Fragment key={index}>{line}</Fragment>]
            : [line]
    );

    const lines6 = str6.split(/\n/);
    const withBreaks6 = lines6.flatMap((line, index) =>
        index > 0
            ? [<br key={`br-${index}`} />, <Fragment key={index}>{line}</Fragment>]
            : [line]
    );



    const [show, setShow] = useState(false)

    const handleOpen = () => {
        setShow(!show);
    };
    return (

        <div className="accordions">
            <div className="accordion_title" onClick={handleOpen}>
                <div className='title_style'>{title}</div>
                <div className="accordion_icon">{show ? "x" : "+"}</div>
            </div>

            {show && (
                <div className="accordion_body">
                    {content}
                </div>
            )}
        </div>
    );
}




export default Accordion
