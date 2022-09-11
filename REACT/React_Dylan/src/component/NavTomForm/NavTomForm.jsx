import React from 'react'
import '../NavTomForm/NavTomForm.scss'



function Nav() {

    
    return (
        <div className="nav">

            <img src="./images/logo.png" className='nav_logo' alt="Netflix" />

            <div className="nav_actions">
                <a href="/" className="nav_action">
                    <button className='btn'>S'identifier</button>
                </a>
            </div>
        </div>
    )
}

export default Nav