

import { ResponsiveBar } from '@nivo/bar'
import React from 'react';

export interface ChartDataItem {
  id: string;
  value: number;
}

interface BarChartProps {
  data: ChartDataItem[];
  title?: string;
}

const BarChart: React.FC<BarChartProps> = ({ data, title }) => {
  const formattedData = [
    data.reduce((acc, curr) => {
      acc['category'] = 'Metrics';
      acc[curr.id] = curr.value;
      return acc;
    }, {} as any),
  ];

  return (
    <div className="bg-white p-6 rounded-xl shadow-md border border-gray-100 w-full">
      {title && <h2 className="text-lg font-semibold mb-4">{title}</h2>}
      <div style={{ height: 300 }}>
        <ResponsiveBar
          data={formattedData}
          keys={data.map((item) => item.id)}
          indexBy="category"
          margin={{ top: 20, right: 30, bottom: 40, left: 40 }}
          padding={0.3}
          colors={{ scheme: 'nivo' }}
          axisBottom={{
            tickRotation: -15,
            legend: 'Categories',
            legendPosition: 'middle',
            legendOffset: 32,
          }}
          axisLeft={{
            tickSize: 5,
            tickPadding: 5,
            legend: 'Value',
            legendPosition: 'middle',
            legendOffset: -40,
          }}
          enableLabel={false}
          animate={true}
          motionConfig="wobbly"
        />
      </div>
    </div>
  );
};

export default BarChart;
