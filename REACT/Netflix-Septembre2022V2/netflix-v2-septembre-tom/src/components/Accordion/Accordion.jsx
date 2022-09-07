import React from 'react'
import { useState } from 'react';
import "./Accordion.scss";


function Accordion() {
const [show, setShow] = useState(false);
const handleOpen = () => {
setShow(!show);
};
return (
<div className="Accordion">
<div className="accordions">
<div className="accordion_title" onClick={handleOpen}>
<div>TITRE ACCORDEON</div>
<div className="accordion_icon">{show ? '-' : '+'}</div>
</div>

{show && (
<div className="accordion-body">
TESTTEXTE TEXTE TEXTETEXTE 
TEXTETEXTETEXTETEXTETEXTETEXTETEXTE TEXTETEXTE
</div>
)}
</div>
</div>
);
}



export default Accordion