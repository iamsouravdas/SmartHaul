import { ResponsivePie } from "@nivo/pie";
import React from "react";
import type { PieChartProps } from "./pie.type";
import "./pie.styles.css";

const PieChart: React.FC<PieChartProps> = (pieChartProps: PieChartProps) => {
  return (
    <div className={`pie-div ${pieChartProps.customChartDivClassName}`}>
      <h3 className="common-heading">{pieChartProps.chartLabel}</h3>
      <ResponsivePie
        data={pieChartProps.data}
        margin={{ top: 40, bottom: 80}}
        innerRadius={0.5}
        padAngle={0.6}
        cornerRadius={2}
        activeOuterRadiusOffset={8}
        colors={{ scheme: "category10" }}
        borderColor={{ theme: "background" }}
        arcLinkLabelsSkipAngle={10}
        arcLinkLabelsTextColor="#333333"
        arcLinkLabelsThickness={2}
        arcLinkLabelsColor={{ from: "color" }}
        arcLabelsSkipAngle={10}
        arcLabelsTextColor={{ from: "color", modifiers: [["darker", 2]] }}
        motionConfig={{
          mass: 93,
          tension: 287,
          friction: 118,
          clamp: false,
          precision: 0.01,
          velocity: 0,
        }}
        transitionMode="pushOut"
         legends={[{ anchor: 'left', direction: 'column', itemWidth: 100, itemHeight: 20, symbolSize: 20 }]}
      />
    </div>
  );
};

export default PieChart;
