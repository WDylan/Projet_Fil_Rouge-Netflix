import "./signUp.scss";

function SignUp() {
    return (
        <div clasName="signUp">
            <div clasName="top">
                <div clasName="signUp-wrapper">
                    <img clasName="logo"
                        src='./img/logo.png' />
                </div>
            </div>
            <div clasName="signUp-container">
                <form>
                    <h1>Inscription</h1>
                    <input type="text" placeholder="Prénom" />
                    <input type="email" placeholder="Adresse Email" />
                    <input type="password" placeholder="Mot de passe"/>
                    <button clasName="loginButton">S'identifier</button>
                    <span>
                       Déjà inscrit ? <b>Connectez-vous.</b>
                    </span>
                </form>

            </div>
        </div>
    )
}

export default SignUp;