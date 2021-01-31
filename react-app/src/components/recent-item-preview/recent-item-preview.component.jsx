
import React from "react";
import "./recent-item-preview.styles.css";
import RecentItem from "../recent-item/recent-item.component";
const RecentItemPreview = ({ title, ads }) => (
  <div>
    <section className="wrapper wrapper-top">
      <h1 className="header">{title}</h1>
      <a className="browse-all" href={`category/`}>
        Browse all
      </a>
    </section>

    <section className="recent-item-list">
      <ul className="recent-item desktop">
        {ads.map((ad) => (
          <RecentItem ad={ad} key={ad._id}></RecentItem>
        ))}
      </ul>
      <ul style={{ width: `${ads.length * 75}%` }} className="recent-item mobile">
        {ads.map((ad) => (
          <RecentItem ad={ad} key={ad._id}></RecentItem>
        ))}
      </ul>
    </section>
  </div>
);
export default RecentItemPreview;
