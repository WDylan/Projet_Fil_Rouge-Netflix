import "./SignInScreen.scss"

import React from "react";
import { NavLink } from "react-router-dom";


function SignInScreen() {






    const signIn = (e) => {

        e.preventDefault();

    };



    return <div className="signupScreen">

        <form>

            <h1>S'identifier</h1>

            <input placeholder="Email" type="email" />

            <input placeholder="Mot de Passe" type="password" />

            <NavLink to='/Formulaire' className={(nav) => nav.isActive ? 'lien Active' : 'lien'}>
                <button type="submit" className="signupScreen_button">S'identifier</button>
            </NavLink>


            <div>

                <input type="checkbox" className="signupScreen_souvenir" />

                <label className="signupScreen_labelsouvenir">  Se souvenir de moi </label>

            </div>



            <h4>

                <span className="signupScreen_grisatre">Première visite sur Netflix ? </span>

                {/* <span className="signupScreen_lien" onClick={register}>Inscrivez-vous.</span> */}
                <NavLink to='/Formulaire' className={(nav) => nav.isActive ? 'lien Active' : 'lien'} id="signupScreen_lien">
                    <li>Inscrivez-vous.</li>
                </NavLink>

            </h4>

        </form>

    </div>



}



export default SignInScreen;