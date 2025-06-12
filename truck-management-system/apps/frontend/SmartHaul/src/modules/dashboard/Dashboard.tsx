import { pieData } from "../../assets/data/charts/pie";
import { cardData } from "../../assets/data/dashboard-data/dashboard";
import Cards from "../../components/cards/Cards";
import CustomPieChart from "../../components/charts/pie/Pie";

const Dashboard = () => {
  return (
    <div>
      <h3 className="common-heading">Dashboard</h3>
      <div className="mt-4 d-flex justify-content-between">
        <div>
          {cardData && <Cards cards={cardData} />}
          {pieData && (
            <CustomPieChart
              chartConfig={{
                colors: "accent",
              }}
              chartLabel="Dock Usage"
              data={pieData}
            />
          )}
        </div>
      <div className="ms-4">
        <h1>TODO: Bar Graph</h1>
      </div>
      </div>
    </div>
  );
};

export default Dashboard;
