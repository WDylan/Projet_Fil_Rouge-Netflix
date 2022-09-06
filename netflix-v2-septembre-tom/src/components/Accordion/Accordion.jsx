import React from 'react'
import { useState } from 'react';
import "./Accordion.scss";


function Accordion({ title, content }){
  const [active, setActive] = useState(false)
  
  const handleToggle = e => {
    setActive(!active)
  }


  return (
    <div className={`accordion ${active && "active"}`}>
      <div className='accordion_title' onClick={handleToggle}>
        {title} <span className='accordion_icon'></span>
        </div>
      <div className='accordion_content'>{content}</div>
    </div>
  )
}

export default Accordion