import './App.css';
import Titulo from './components/Titulo/Titulo';
import CardEvento from './components/CardEvento/CardEvento';


function App() {
  return (
    <div className="App">
      
      <h1> Paz entre nos, guerra aos senhores!</h1>


      
      <Titulo texto = "Karlinhos" />
      
      <CardEvento 
      titulo = "Festa no APE"
      descricao = "Pode aparece, vai rola bundalele" 
      />
      
    </div>
  );
}

export default App;
