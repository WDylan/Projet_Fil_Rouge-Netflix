import React from 'react'
import '../NavForm/NavForm.scss'

function NavForm() {
    return (

        <div className='navForm'>

            <img src="/img/logo.png" className='navFormLogo' alt="Netflix" />

            <div className="navFormActions">
                <a href="/" className="navFormAction">
                    <button className="navFormBtn">S'identifier</button>
                </a>
            </div>
        </div>


    )
}

export default NavForm