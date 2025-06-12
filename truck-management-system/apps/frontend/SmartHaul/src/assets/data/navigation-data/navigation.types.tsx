import type { ReactNode } from "react";

export type Navigation = {
  label: string;
  icon: ReactNode;
  url: string;
}[];

export type HeaderRightSightPanel = {
  labelName: string;
  element: any;
  url?: string | null;
  click?: () => void;
}[];
