import React from 'react'
import { useState } from 'react'
import '../AccordionFAQ/AccordionFAQ.scss'

function AccordionFAQ({title, content}) {
    const [show, setShow] = useState(false)

    const handleOpen = () => {
        setShow(!show);
    };
    return (
        <div className='FAQParent'>
            <div className='accordions'>
                <div className='accordion_title' onClick={handleOpen}>
                    <div className='title_style'>{title}</div>
                    <div className='accordion_icon'>{show ? "x" : "+"}</div>
                </div>

                {show && (
                    <div className='accordion_body'>
                        {content}
                    </div>
                )}
            </div>

        </div>
    )
}

export default AccordionFAQ