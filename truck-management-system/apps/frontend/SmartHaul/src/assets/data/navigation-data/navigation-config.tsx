import Profile from "../../../components/profile/Profile";
import icons from "../../icons/icons";
import { profile } from "../profile-data/profile-config";
import type { HeaderRightSightPanel, Navigation } from "./navigation.types";

export const navigation: Navigation = [
  {
    label: "Dashboard",
    icon: icons["dashboard-icon"],
    url: "/dashboard",
  },
  {
    label: "Trucks",
    icon: icons["truck-icon"],
    url: "/trucks",
  },
  {
    label: "Docks",
    icon: icons["dock-icon"],
    url: "./docks",
  },
  {
    label: "Warehouses",
    icon: icons["warehouse-icon"],
    url: "/warehouses",
  },
  {
    label: "Analytics",
    icon: icons["analytics-icon"],
    url: "./analytics",
  },
  {
    label: "Settings",
    icon: icons["settings-icon"],
    url: "./analytics",
  },
];

export const rightSideHeaderPanel: HeaderRightSightPanel = [
  {
    labelName: "Profile",
    element: <Profile image={profile.image} name={profile.name} />,
  },
];
