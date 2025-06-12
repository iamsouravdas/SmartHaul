import { Outlet } from "react-router-dom";
import { rightSideHeaderPanel } from "../../assets/data/navigation-data/navigation-config";
import logo from "../../assets/images/logo.png";
import Navigation from "../navigation/Navigation";
import "./layout.style.css";

const Layout = () => {
  return (
    <>
      <div className="d-flex justify-content-between">
        <img src={logo} alt="logo" className="logo" />
        <div className="d-flex header-rs-panel">
          {rightSideHeaderPanel.map((item, index) => (
            <div key={index}>{item.element}</div>
          ))}
        </div>
      </div>
      <div className="d-flex">
        <Navigation />
        <div className="mt-4 ms-4">
          <Outlet />
        </div>
      </div>
    </>
  );
};

export default Layout;
