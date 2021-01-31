/** @format */

import React from "react";
import "./card.styles.css";
import NoImage from "../../no-image.png";
export const Card = (props) => (
  <li>
    <a href='#' className='cover'>
      <img
        alt={props.ad._id}
        className='card-image'
        src={props.ad.pictures[0].url}
      />
    </a>
    <p>
      <a href='#'>{props.ad.title}</a>
    </p>
  </li>

  /*
  
  <div classNameName={props.col}>
    <div classNameName='column'>
      <div classNameName='post-module'>
        <div classNameName='thumbnail'>
          <div className='date'>
            <div className='day'>{new Date(props.ad.updatedAt).getDate()}</div>
            <div className='month'>
              {new Date(props.ad.updatedAt).toLocaleString("default", {
                month: "short",
              })}
            </div>
          </div>
          {props.ad.pictures.length !== 0 ? (
            <img
              alt={props.ad._id}
              classNameName='card-image'
              src={props.ad.pictures[0].url}
            />
          ) : (
            <img alt='' src={NoImage} />
          )}
        </div>

        <div classNameName='post-content'>
          <div className='category'>${props.ad.price}</div>
          <h1 classNameName='title'>
            <a href=''>{props.ad.title}</a>
          </h1>
        </div>
      </div>
    </div>
  </div>
  */
);
