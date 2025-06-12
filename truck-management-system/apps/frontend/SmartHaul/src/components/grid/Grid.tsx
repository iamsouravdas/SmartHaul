import type React from "react";

export interface GridProps {
  row: number;
  cols: number;
  data: any;
}

const Grid: React.FC<{ grid: GridProps[] }> = ({ grid }) => {
  return (
    <>
      {grid.map((element: any) => {
        return element;
      })}
    </>
  );
};

export default Grid;
