import './App.scss';
import Nav from './component/Nav';
import Footer from './component/Footer';
import Banner from './component/Banner';
import Row from './component/Row'
import requests from './config/Requests';

function App() {
  return (
    <div className="App">
      {/* Navbar */}
      <Nav />

      {/* Banner */}
      <Banner />

      {/* Row s*/}
      <Row title="Appréciés sur Netflix" fetchurl={requests.fetchNetflixOriginals}/>
      <Row title="Tendances actuelles" fetchurl={requests.fetchTrending}/>
      <Row title="Les mieux notés" fetchurl= {requests.fetchTopRated}/>
      <Row title="Documentaire" fetchurl= {requests.fetchDocumentaries}/>
      <Row title="Films d'actions" fetchurl= {requests.fetchActionMovies}/>
      <Row title="Comédies" fetchurl= {requests.fetchComedyMovies}/>
      <Row title="Films d'horreur" fetchurl= {requests.fetchHorrorMovies}/>
      <Row title="Films romantique" fetchurl= {requests.fetchRomanceMovies}/>

      {/* Vidéo*/}


      {/* Quick view */}


      {/* Footer */}
      <Footer />

    </div>
  );
}

export default App;
