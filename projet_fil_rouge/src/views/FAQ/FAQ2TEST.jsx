import React from 'react';
import './FAQ2TEST.css';
import 'bootstrap/dist/css/bootstrap.css';
import "bootstrap";
import Footer from '../../components/FooterComponent/Footer';
import Accordion from 'react-bootstrap/Accordion';
import { useAccordionButton } from 'react-bootstrap/AccordionButton';
import Card from 'react-bootstrap/Card';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPlus } from "@fortawesome/free-solid-svg-icons";

function Example() {
    return (
        <div class="our-story-card faq-card" data-uia-nmhp="faq" data-uia="our-story-card" id="faq">
            <div class="our-story-card-text">
                <h1 id="" class="our-story-card-title" data-uia="faq-title">Foire aux questions</h1>
                <ul class="faq-list">
                    <li class="faq-list-item" data-uia-nmhp="faq-list-item" data-uia-faq="what_is_netflix">
                        <button class="faq-question">
                            Netflix, qu'est-ce que c'est&nbsp;?
                            <svg id="thin-x" viewBox="0 0 26 26" class="svg-icon svg-icon-thin-x svg-closed" focusable="true">
                                <path d="M10.5 9.3L1.8 0.5 0.5 1.8 9.3 10.5 0.5 19.3 1.8 20.5 10.5 11.8 19.3 20.5 20.5 19.3 11.8 10.5 20.5 1.8 19.3 0.5 10.5 9.3Z"></path>
                            </svg>
                        </button>
                        <div class="faq-answer closed">
                            <span id="" data-uia="">
                                Netflix est un service
                            </span>
                        </div>
                    </li>
                </ul>
            </div>
        </div>



    );
};













var acc = document.getElementsByClassName("accordion");
var i;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
            panel.style.display = "none";
        } else {
            panel.style.display = "block";
        }
    });
}








{/* function Example() {
    return (
        <Card>
            <Card.Header>
                <button className='accordion'>Netflix, qu'est-ce que c'est ?</button>
                <div className='panel'>
                    <p>Netflix est un service de streaming qui propose une vaste sélection de séries, films, animes, documentaires et autres programmes primés sur des milliers d'appareils connectés à Internet.

                        Regardez tout ce que vous voulez, quand vous voulez, sans publicité et à un tarif mensuel très attractif. Découvrez de nouveaux films et séries chaque semaine, il y en a pour tous les goûts !</p>
                </div>

                <button className='accordion'>Combien coûte Netflix ?</button>
                <div className='panel'>
                    <p>Regardez Netflix sur votre smartphone, tablette, Smart TV, ordinateur ou appareil de streaming, le tout pour un tarif mensuel fixe. Les forfaits vont de 8,99 € à 17,99 € par mois. Pas de contrat ni de frais supplémentaires.</p>
                </div>

                <button className='accordion'>Où puis-je regarder Netflix ?</button>
                <div className='panel'>
                    <p>Netflix, c'est où vous voulez, quand vous voulez. Connectez-vous à votre compte pour regarder Netflix en ligne sur netflix.com depuis votre ordinateur ou tout appareil connecté à Internet avec l'application Netflix, comme les Smart TV, smartphones, tablettes, lecteurs de streaming et consoles de jeu.

                        Vous pouvez aussi télécharger vos séries préférées avec l'application iOS, Android ou Windows 10. Téléchargez des titres pour les regarder sur votre appareil mobile, même sans connexion Internet. Emportez Netflix partout avec vous.</p>
                </div>

                <button className='accordion'>Comment puis-je annuler mon forfait ?</button>
                <div className='panel'>
                    <p>Netflix offre une grande souplesse. Pas de contrat compliqué. Sans engagement. Deux clics suffisent pour annuler votre compte en ligne. Pas de frais d'annulation : ouvrez ou fermez votre compte à tout moment.</p>
                </div>

                <button className='accordion'>Que puis-je regarder sur Netflix ?</button>
                <div className='panel'>
                    <p>Netflix propose un vaste catalogue comprenant notamment des longs métrages, des documentaires, des séries, des animes et des programmes originaux Netflix primés. Regardez Netflix à volonté, quand vous le voulez.</p>
                </div>

                <button className='accordion'>Est-ce que Netflix est adapté aux enfants ?</button>
                <div className='panel'>
                    <p>Netflix Jeunesse est inclus dans votre abonnement et offre un meilleur contrôle aux parents, ainsi qu'un espace dédié aux enfants, avec des films et des séries destinés à toute la famille.

                        Les profils Jeunesse comportent des fonctionnalités de contrôle parental avec code PIN permettant de modifier la catégorie d'âge des contenus que vos enfants peuvent regarder et de bloquer des titres spécifiques.</p>
                </div>
            </Card.Header>
        </Card>
    );}; */}


















// function CustomToggle({children, eventKey}) {
//     const decoratedOnClick = useAccordionButton(eventKey, () =>
//         console.log('totally custom!'),
//     );

//     return (
//         <span
//             type="button"
//             onClick={decoratedOnClick}
//         >
//             {children}
//         </span>
//     );
// }

export default Example;



