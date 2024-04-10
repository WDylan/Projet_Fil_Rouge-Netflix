import "./SignInScreen.scss"
import React from "react";

function SignInScreen() {

    const register = (e) => {
        e.preventDefault();
    };

    const signIn = (e) => {
        e.preventDefault();
    };

    return <div className="signupScreen">
        <form>
            <h1>S'identifier</h1>
            <input placeholder="Email" type="email" />
            <input placeholder="Mot de Passe" type="password" />
            <button type="submit" onClick={signIn}>S'identifier</button>
            <div>
                <input type="checkbox" className="signupScreen_souvenir"/>
                <label className="signupScreen_labelsouvenir">  Se souvenir de moi </label>
            </div>

            <h4>
                <span className="signupScreen_grisatre">Première visite sur Netflix ? </span>
                <span className="signupScreen_lien" onClick={register}>Inscrivez-vous.</span>
            </h4>
        </form>
    </div>

}

export default SignInScreen;