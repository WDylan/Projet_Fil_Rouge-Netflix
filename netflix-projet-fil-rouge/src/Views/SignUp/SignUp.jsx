import "./SignUp.scss"
import { Link } from 'react-router-dom';

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
                    <button className="loginButton"><Link to='./signup'>S'identifier</Link></button>
                    <span>
                       Déjà inscrit ? 
                       <Link to='./login'><b>Connectez-vous.</b></Link>
                    </span>
                </form>

            </div>
        </div>
    )
}

export default SignUp;