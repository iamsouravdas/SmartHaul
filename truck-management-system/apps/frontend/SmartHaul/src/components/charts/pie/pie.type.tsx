export type ChartDatum = {
  id: string;
  label: string;
  value: number;
};

export type PieChartProps = {
  chartLabel: string;
  customChartDivClassName?: string;
  data: ChartDatum[];
  chartConfig?: 
    {
      innerRadius? : number;
      padAngle? : number;
      colors? : "category10" | "accent" | "dark2" | "paired";
      arcLabelColor?: string;
    }
};