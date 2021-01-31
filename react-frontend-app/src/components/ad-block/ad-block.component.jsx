import React from "react";

import "./ad-block.styles.css";

const AdBlock = (props) => (
  <div
    className={`ad-block ${props.adOption.size}`}
    style={{
      color: `${props.adOption.color}`,
      backgroundColor: `${props.adOption.bgColor}`,
      backgroundImage: `url(${props.adOption.bgImage})`,
      backgroundSize: 'cover',
      backgroundRepeat: 'no-repeat',
      backgroundPosition:'center'
    }}
  >
    <div className={`${props.adOption.size}`}>
      <h2>{props.adOption.title}</h2>
      <p>{props.adOption.body}</p>
    </div>
  </div>
);

export default AdBlock;
