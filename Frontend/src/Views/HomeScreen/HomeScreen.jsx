import Nav from '../../component/Nav';
import Footer from '../../component/Footer';
import Banner from '../../component/Banner';
import Row from '../../component/Row'
import requests from '../../config/Requests';
import './HomeScreen.scss';

function HomeScreen() {
    return (
        <div>
            <Nav />

            {/* Banner */}
            <Banner />

            {/* Row s*/}
            <Row title="Programmes Originaux Netflix" fetchUrl={requests.fetchNetflixOriginals} isPoster={true} />
            <Row title="Tendances actuelles" fetchUrl={requests.fetchTrending} />
            <Row title="Les mieux notés" fetchUrl={requests.fetchTopRated} />
            <Row title="Documentaires" fetchUrl={requests.fetchDocumentaries} />
            <Row title="Films d'action" fetchUrl={requests.fetchActionMovies} />
            <Row title="Comédies" fetchUrl={requests.fetchComedyMovies} />
            <Row title="Films d'horreur" fetchUrl={requests.fetchHorrorMovies} />
            <Row title="Films romantique" fetchUrl={requests.fetchRomanceMovies} />

            {/* Vidéo*/}


            {/* Quick view */}


            {/* Footer */}
            <Footer />

        </div>
    )
}

export default HomeScreen;