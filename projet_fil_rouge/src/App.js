import './App.css';
import Body from './components/BodyComponent/Body';
import Footer from './components/FooterComponent/Footer';
import Header from './components/HeaderComponent/Header';
import FAQ from './views/FAQ/FAQ';

function App() {
  return (
    <div className="App">
      
      <Body />
      <FAQ />
      <Header />
      {/* <Footer /> */}
    </div>
  );
}

export default App;
