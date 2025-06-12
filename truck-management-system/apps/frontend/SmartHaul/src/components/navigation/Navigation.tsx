import { useNavigate } from "react-router-dom";
import { navigation } from "../../assets/data/navigation-data/navigation-config";
import "./navigation.style.css";

const Navigation = () => {
  const navigate = useNavigate();
  return (
    <>
      <div className="side-bar mt-4">
        {navigation.map((element, index) => (
          <div
            className="menu-item-row "
            data-tooltip={element.label}
            key={index}
          >
            <div className="nav-item" onClick={() => navigate(element.url)}>
              <div className="menu-icon">{element.icon}</div>
            </div>
          </div>
        ))}
      </div>
    </>
  );
};

export default Navigation;
