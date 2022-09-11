import React from 'react';
import "../../src/component/Style/Footer2.scss";
import FacebookIcon from '@mui/icons-material/Facebook';
import InstagramIcon from '@mui/icons-material/Instagram';
import TwitterIcon from '@mui/icons-material/Twitter';
import YouTubeIcon from '@mui/icons-material/YouTube';

function Footer() {
  return (
    <footer className='footer'>
        <div className='separation'> </div>
        <div className="container">
            <div className="footer_socials">
                <a href="https://fr-fr.facebook.com/netflixfrance/" className="footer_social">
                    <FacebookIcon/>
                </a>
                <a href="https://www.instagram.com/netflixfr/" className="footer_social">
                    <InstagramIcon/>
                </a>
                <a href="https://twitter.com/NetflixFR" className="footer_social">
                    <TwitterIcon/>
                </a>
                <a href="https://www.youtube.com/c/NetflixFrance/featured" className="footer_social">
                    <YouTubeIcon/>
                </a>
            </div>
            <ul className="footer_links">
                <li className="footer_link">
                    <a href="/">FAQ</a>
                </li>
                <li className="footer_link">
                    <a href="/">Relations Investisseurs</a>
                </li>
                <li className="footer_link">
                    <a href="/">Modes de lecture</a>
                </li>
                <li className="footer_link">
                    <a href="/">Mentions légales</a>
                </li>
                <li className="footer_link">
                    <a href="/">Informations légales</a>
                </li>
                <li className="footer_link">
                    <a href="/">Centre d'aide</a>
                </li>
                <li className="footer_link">
                    <a href="/">Recrutement</a>
                </li>
                <li className="footer_link">
                    <a href="/">Conditions d'utilisation</a>
                </li>
                <li className='footer_link'>
                        <a href='/'>Nous contacter</a>
                    </li>
                    <li className='footer_link'>
                        <a href='/'>Seulement sur Netflix</a>
                    </li>
                    <li className='footer_link'>
                        <a href='/'>Compte</a>
                    </li>
                    <li className='footer_link'>
                        <a href='/'>C'est la crise à Hollywood... Vive la grande famille du cinéma français !</a>
                    </li>
            </ul>
            <div className="footer_copy">Netflix Clone - Projet fil rouge - Dylan, Myriam, Thomas</div>
        </div>
    </footer>
  )
}

export default Footer