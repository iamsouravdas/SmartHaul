import { BsColumnsGap, BsGraphUp } from "react-icons/bs";
import { FaTruckMoving } from "react-icons/fa";
import { FaDoorOpen, FaTruckFast } from "react-icons/fa6";
import { IoNotificationsCircle, IoSettingsOutline } from "react-icons/io5";
import { MdOutlineWarehouse } from "react-icons/md";
import "./icons.styles.css";

const icons ={
    "notify-icon": <IoNotificationsCircle className="notification"/>,
    "truck-icon": <FaTruckMoving />,
    "dashboard-icon": <BsColumnsGap />,
    "truck-icon-movinbg": <FaTruckFast />,
    "dock-icon": <FaDoorOpen />,
    "warehouse-icon": <MdOutlineWarehouse />,
    "analytics-icon":<BsGraphUp />,
    "settings-icon":  <IoSettingsOutline />,
}

export default icons;