import './App.scss';
import Nav from './components/Nav/Nav';
import Banner from './components/Banner/Banner';
import Footer from './components/Footer/Footer';
import Accordion from './components/Accordion/Accordion';

function App() {
  return (
    <div className="App">
      <Nav />
      <Banner />
      {/* <Row/> */}
      <div className='FAQ_title'>Foire aux questions</div>
      <div className='accordions'>        
        <Accordion title="Netflix, qu'est-ce que c'est ?" content="TEST TEXTE" />
        <Accordion title="Combien coûte Netflix ?" content="Contenu 2" />
        <Accordion title="Où puis-je regarder Netflix ?" content="Contenu 3" />
        <Accordion title="Comment puis-je annuler mon forfait ?" content="Contenu 4" />
        <Accordion title="Que puis-je regarder sur Netflix ?" content="Contenu 5" />
        <Accordion title="Est-ce que Netflix est adapté aux enfants ?" content="Contenu 6" />
      </div>



      {/* rows */}

      {/* video */}
      {/* quickview */}

      <Footer />
    </div>
  );
}

export default App;
