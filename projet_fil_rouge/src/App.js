import './App.css';
import NavBar from './components/NavBarComponent/NavBar';
import Body from './components/BodyComponent/Body';
import Footer from './components/FooterComponent/Footer';
import Header from './components/HeaderComponent/Header';
import FAQ from './views/FAQ/FAQ';

function App() {
  return (
    <div className="App">
      <NavBar />
      <Body />
      <FAQ />
      <Header />
      <Footer />
    </div>
  );
}

export default App;
