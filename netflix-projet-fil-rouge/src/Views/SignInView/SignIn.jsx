import './SignIn.scss'
import { Link } from 'react-router-dom';

function Login() {
    return (
        <div clasName="login">
            <div clasName="top">
                <div clasName="login-wrapper">
                    <img clasName="logo"
                        src='./img/logo.png' />
                </div>
            </div>
            <div clasName="login-container">
                <form>
                    <h1>S'identifier</h1>
                    <input type="email" placeholder="E-mail ou numéro de téléphone" />
                    <input type="password" placeholder="Mot de passe"/>
                    <button className="loginButton"><Link to='./login'>S'identifier</Link></button>
                    <span>
                        Première visite sur Netflix ? <Link to='./signup'><b>Inscrivez-vous.</b></Link>
                    </span>
                    <small>
                        Cette page est protégée par Google reCAPTCHA pour nous assurer que vous n'êtes pas un robot. <b>En savoir plus.</b>
                    </small>
                </form>

            </div>
        </div>
    )
}

export default Login;