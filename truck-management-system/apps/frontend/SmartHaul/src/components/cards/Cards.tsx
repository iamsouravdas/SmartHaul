import type { CardProps } from "./cards.type";
import "./cards.styles.css";
const Cards: React.FC<{ cards: CardProps[] }> = ({ cards }) => {
  return (
    <div className="d-flex justify-content-between cursor-pointer">
      {cards &&
        cards.map((data: CardProps, index) => (
          <div key={index} className="card info-cards ">
            <div className="d-flex">
              <div className="me-2 fs-5 text-secondary">
              {data.icon}
              </div>
              <div className="fs-6 text mt-1 text-secondary">{data.heading}</div>
            </div>
            <div className="fs-1 fw-medium count">{data.count}</div>
          </div>
        ))}
    </div>
  );
};

export default Cards;
