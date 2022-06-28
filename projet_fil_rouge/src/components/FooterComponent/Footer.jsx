import React from 'react';
import "./Footer.scss";
import FacebookIcon from '@mui/icons-material/Facebook';
import InstagramIcon from '@mui/icons-material/Instagram';
import TwitterIcon from '@mui/icons-material/Twitter';
import YouTubeIcon from '@mui/icons-material/YouTube';

function Footer() {
    return (
        <footer className="footer">
            <div className='container'>
                <p className='footer__top'>Des questions ? Appelez le
                    <a className='footer__top-a' href='tel:(+33) 0805-543-063'>(+33) 0805-543-063</a>
                </p>
                <div className='footer__socials'>
                    <a href='https://fr-fr.facebook.com/netflixfrance/' className='footer__social'>
                        <FacebookIcon />
                    </a>
                    <a href='https://www.instagram.com/netflixfr/'className='footer__social'>
                        <InstagramIcon />
                    </a>
                    <a href='https://twitter.com/NetflixFR' className='footer__social' >
                        <TwitterIcon />
                    </a>
                    <a href='https://www.youtube.com/c/NetflixFrance/featured' className='footer__social'>
                        <YouTubeIcon />
                    </a>
                </div>
                <ul className='footer__links'>
                    <li className='footer__link'>
                        <a href='/'>FAQ</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Relations Investisseurs</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Modes de lecture</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Mentions légales</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Informations légales</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Centre d'aide</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Recrutement</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Conditions d'utilisation</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Nous contacter</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Seulement sur Netflix</a>
                    </li>
                    <li className='footer__link'>
                        <a href='/'>Compte</a>
                    </li>
                </ul>
                <div className='footer__copy'>
                    Netflix - Projet fil rouge
                </div>
            </div>
        </footer >
    )
}

export default Footer;