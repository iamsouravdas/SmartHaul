import { Route, Routes } from "react-router-dom"
import Analytics from "../modules/analytics/Analytics"
import Dashboard from "../modules/dashboard/Dashboard"
import Docks from "../modules/dock/views/Dashboard/Docks"
import Trucks from "../modules/truck/views/dashboard/Trucks"
import Layout from "../components/layout/Layout"
import { route } from "./routes"

const RouteNavigator = () => {
  return (
    <Routes>
        <Route element={<Layout/>}>
        <Route path={route.dashboard} element={<Dashboard/>}/>
        <Route path={route.truck} element={<Trucks/>}/>
        <Route path={route.docks} element={<Docks/>}/>
        <Route path={route.warehouse} element={<Trucks/>}/>
        <Route path={route.analytics} element={<Analytics/>}/>
        <Route path={route.settings} element={<Trucks/>}/>
        </Route>
    </Routes>
  )
}

export default RouteNavigator;
