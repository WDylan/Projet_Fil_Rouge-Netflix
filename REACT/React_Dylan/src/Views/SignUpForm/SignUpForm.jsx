import React from 'react'
import BannerForm from '../../component/BannerForm/BannerForm'
import Footer from '../../component/Footer'
import NavForm from '../../component/NavForm/NavForm'
import '../SignUpForm/SignUpForm.scss'


function SignUpForm() {
    return (
        <div className='SignUpForm'>
            <NavForm />
            <BannerForm />
            <div className='separation1'></div>
            <Footer />
        </div>
    )
}

export default SignUpForm