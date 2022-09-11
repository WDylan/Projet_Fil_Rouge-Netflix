import React from 'react'
import '../BannerForm/BannerForm.scss'
import HomeScreen from '../../Views/HomeScreen/HomeScreen'
import { useNavigate } from 'react-router'



function BannerForm() {
    const navigate = useNavigate();
    const navigateToHome = () => {
        navigate('/Home');
    };
    return (
        <div className='banner_content'>
            <div className='banner_title'>
                Créez un mot de passe pour activer votre abonnement<br />
            </div>
            <span className='_span_1'>Veuillez remplir les champs ci-après pour vous inscrire<br />
                Prêt à regarder Netflix ?</span>
            <span className='_span_2'> Une fois votre inscription effectuée, profitez immédiatement de Netflix !</span>

            <form className='firstname_input'>
                <input placeholder='Prénom' className='firstname' />
            </form>
            <form className='lastname_input'>
                <input placeholder='Nom' className='lastname' />
            </form>
            <form className='email_input'>
                <input placeholder='Adresse e-mail' className='email' />
            </form>
            <form className='password_input'>
                <input placeholder='Mot de passe' className='password' />
            </form>
            <button className='valider_inscription' onClick={navigateToHome}>Valider</button>
        </div>
    )
}

export default BannerForm