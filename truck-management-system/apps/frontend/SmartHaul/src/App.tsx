import { BrowserRouter } from "react-router-dom"
import RouteNavigator from "./routes/RouteNavigator";
import "./assets/css/App.css";

function App() {
  return (
    <>
    <BrowserRouter>
      <RouteNavigator></RouteNavigator>
    </BrowserRouter>
      
    </>
  )
}

export default App
