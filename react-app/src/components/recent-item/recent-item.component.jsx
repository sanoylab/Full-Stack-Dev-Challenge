import React from 'react';
import './recent-item.styles.css';
import { Link } from 'react-router-dom';

const RecentItem = (props) => (
    <li>
    <a href={`/buy-and-sell/${props.ad._id}`} className='cover'>
    <div
      className={`cover`}
        style={{
        
        backgroundColor: `#ccc`,
        backgroundImage: `url(${props.ad.pictures[0].url})`,
        backgroundSize: 'cover',
        backgroundRepeat: 'no-repeat',
        backgroundPosition:'center'
        }}
    >&nbsp;</div>
      
    </a>
    <p>
    <Link to={`/buy-and-sell/${props.ad._id}`}>{props.ad.title}</Link>
    </p>
  </li>
)

export default RecentItem;