// import React from 'react';
import './FAQ.css';
import 'bootstrap/dist/css/bootstrap.css';
import "bootstrap";
import AddIcon from '@mui/icons-material/Add';
import NavBar from '../../components/NavBarComponent/NavBar';

const FAQ = () => {
    return (

        <div className='container-fluid'>
            <div className='title'>
                <h1>Frequently asked questions</h1>
            </div>

            <div class="accordion accordion-flush" id="accordionFlushExample">
                <div class="accordion-item" id="backgroundColor">
                    <h2 class="accordion-header" id="flush-headingOne">
                        <button id="backgroundColor" class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                            <div className='titleColor'>Netflix, qu'est-ce que c'est ? <AddIcon /></div>
                        </button>
                    </h2>
                    <div id="flush-collapseOne" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">
                            <p>Netflix est un service de streaming qui propose une vaste sélection de séries TV, films, animes, documentaires et autres programmes primés sur des milliers d'appareils connectés à Internet.</p><br />
                            <p>Regardez tout ce que vous voulez, quand vous voulez, sans publicité et à un tarif mensuel très attractif. Découvrez de nouveaux films et séries TV chaque semaine, il y en a pour tous les goûts !</p>
                        </div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header" id="flush-headingTwo">
                        <button id="backgroundColor" class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                            <div className="titleColor">Combien coûte Netflix ? <AddIcon /></div>
                        </button>
                    </h2>
                    <div id="flush-collapseTwo" class="accordion-collapse collapse" aria-labelledby="flush-headingTwo" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Regardez Netflix sur votre smartphone, tablette, Smart TV, ordinateur ou appareil de streaming, le tout pour un tarif mensuel fixe. Les forfaits vont de 8,99 € à 17,99 € par mois. Pas de contrat ni de frais supplémentaires.</div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header" id="flush-headingThree">
                        <button id="backgroundColor" class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseThree" aria-expanded="false" aria-controls="flush-collapseThree">
                            <div className="titleColor">Où puis-je regarder Netflix ? <AddIcon /></div>
                        </button>
                    </h2>
                    <div id="flush-collapseThree" class="accordion-collapse collapse" aria-labelledby="flush-headingThree" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Netflix, c'est où vous voulez, quand vous voulez. Connectez-vous à votre compte pour regarder Netflix en ligne sur netflix.com depuis votre ordinateur ou tout appareil connecté à Internet avec l'application Netflix, comme les Smart TV, smartphones, tablettes, lecteurs de streaming et consoles de jeu.

                            Vous pouvez aussi télécharger vos séries préférées avec l'application iOS, Android ou Windows 10. Téléchargez des titres pour les regarder sur votre appareil mobile, même sans connexion Internet. Emportez Netflix partout avec vous.</div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header" id="flush-headingFour">
                        <button id="backgroundColor" class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseFour" aria-expanded="false" aria-controls="flush-collapseFour">
                            <div className="titleColor">Comment puis-je annuler mon forfait ? <AddIcon /></div>
                        </button>
                    </h2>
                    <div id="flush-collapseFour" class="accordion-collapse collapse" aria-labelledby="flush-headingFour" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Netflix offre une grande souplesse. Pas de contrat compliqué. Sans engagement. Deux clics suffisent pour annuler votre compte en ligne. Pas de frais d'annulation : ouvrez ou fermez votre compte à tout moment.</div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header" id="flush-headingFive">
                        <button id="backgroundColor" class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseFive" aria-expanded="false" aria-controls="flush-collapseFive">
                            <div className="titleColor">Que puis-je regarder sur Netflix ? <AddIcon /></div>
                        </button>
                    </h2>
                    <div id="flush-collapseFive" class="accordion-collapse collapse" aria-labelledby="flush-headingFive" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Netflix propose un vaste catalogue comprenant notamment des longs métrages, des documentaires, des séries TV, des animes et des programmes originaux Netflix primés. Regardez Netflix à volonté, quand vous le voulez.</div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header" id="flush-headingSix">
                        <button id="backgroundColor" class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseSix" aria-expanded="false" aria-controls="flush-collapseSix">
                            <div className="titleColor">Est-ce que Netflix est adapté aux enfants ? <AddIcon /></div>
                        </button>
                    </h2>
                    <div id="flush-collapseSix" class="accordion-collapse collapse" aria-labelledby="flush-headingSix" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Netflix Jeunesse est inclus dans votre abonnement et offre un meilleur contrôle aux parents, ainsi qu'un espace dédié aux enfants, avec des films et des séries destinés à toute la famille.

                            Les profils Enfants comportent des fonctionnalités de contrôle parental avec code PIN permettant de modifier la catégorie d'âge des contenus que vos enfants peuvent regarder et de bloquer des titres spécifiques.</div>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default FAQ;