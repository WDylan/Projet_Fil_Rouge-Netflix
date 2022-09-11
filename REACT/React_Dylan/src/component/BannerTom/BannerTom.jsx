import React from 'react';
import "../../component/BannerTom/BannerTom.scss";

function Banner() {

    const bannerStyle = {
        backgroundImage: `url("/img/FR-fr-20220620-popsignuptwoweeks-perspective_alpha_website_largeDARK.jpg")`,
        backgroundSize: "cover",
        backgroundPosition: "center center",
    }


    return (
        <header className='banner' style={bannerStyle}>
            <div className='banner_content'>
                <h1 className='banner_title'>
                    Films, séries et bien plus en illimité.<br />
                </h1>
                <span className='_span_1'>Où que vous soyez. Annulez à tout moment.<br />
                    Prêt à regarder Netflix ?</span>
                <span className='_span_2'> Saisissez votre adresse e-mail pour vous abonner ou réactiver votre abonnement.</span>

                <form className='email_input'>
                    <input placeholder='Adresse e-mail' className='email'></input>
                    <button className='email_button'>Commencer</button>
                </form>
            </div>
        </header>
    )


}

export default Banner;