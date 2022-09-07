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
             
        <Accordion/>
        <Accordion/>
        <Accordion/>
        <Accordion/>
        <Accordion/>

        
      



      {/* rows */}

      {/* video */}
      {/* quickview */}

      <Footer />
    </div>
  );
}

export default App;
