import { useState } from 'react';
import './LoginScreen.scss'
import SignInScreen from '../SignIn/SignInScreen';
import HomeScreen from '../HomeScreen/HomeScreen';

function LoginScreen() {
    const [signIn, setSignIn] = useState(false);
    return (
        <div className='loginScreen'>
            <div className="loginScreen_background">
                <a href={<HomeScreen/>}>
                    <img className='loginScreen_logo'
                        src='./img/logo.png'/>
                </a>
                <button onClick={() => setSignIn(true)}
                    className='loginScreen_button'>
                    Sign In
                </button>
                <div className='loginScreen_gradient'></div>
            </div>

            <div className='loginScreen_body'>
                {signIn ? (
                    <SignInScreen />
                ) :
                    <>
                        <h1>Films, séries et bien plus en illimité.</h1>
                        <h2>Où que vous soyez. Annulez à tout moment.</h2>
                        <h3>Prêt à regarder Netflix ? Saisissez votre adresse e-mail pour vous abonner ou réactiver votre abonnement.</h3>

                        <div className="loginScreen_input">
                            <form>
                                <input type="email" placeholder="Adresse e-mail" />
                                <button onClick={() => setSignIn(true)}
                                    className='loginScreen_Commencer'>
                                    Commencer 
                                </button>
                            </form>
                            <div class="loginScreen_inputError">
                                L'e-mail est obligatoire !
                            </div>
                        </div>
                    </>
                }
            </div>
        </div>
    )
}

export default LoginScreen;