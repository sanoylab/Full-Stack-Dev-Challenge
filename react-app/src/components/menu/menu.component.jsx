import React, { Component } from "react";
import "./menu.styles.css";
import { Link } from "react-router-dom";

class Menu extends Component {
  constructor() {
    super();
    this.state = {
      menuItems: [
        {
          id: 1,
          title: `Categories`,
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/Category-512.png",
          linkUrl: "buy-sell/all-categories",
        },
        {
          id: 2,
          title: "Furnitures",
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/Sofa-512.png",
          linkUrl: "buy-sell/furnitures",
        },
        {
          id: 3,
          title: "Clothing",
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/Men-Shirt-03-512.png",
          linkUrl: "buy-sell/clothing",
        },
        {
          id: 4,
          title: "RealEstate",
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/Home-512.png",
          linkUrl: "buy-sell/real-estate",
        },
        {
          id: 5,
          title: "BabyItems",
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/Baby-512.png",
          linkUrl: "buy-sell/baby-items",
        },
        {
          id: 6,
          title: "Computers",
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/Laptop-01-512.png",
          linkUrl: "buy-sell/computers",
        },
        {
          id: 7,
          title: "Phones",
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/I-Phone-512.png",
          linkUrl: "buy-sell/phones",
        },
        {
          id: 8,
          title: "SignIn",
          imageUrl: "https://gebeya-online-assets.s3.ca-central-1.amazonaws.com/User-Login-512.png",
          linkUrl: "signin",
        },
      ],
    };
  }
  render() {
    return (
      <div className="navbar-area">
        <div className="container">
          <nav className="site-navbar">
            <ul>
              {this.state.menuItems.map((menu) => (
                <li className="action" key={menu.id}>
                   <img className='menu-icon'alt={menu.title} src={menu.imageUrl} /><Link to={menu.linkUrl}>
                   
                    {menu.title}</Link>
                </li>
              ))}
            </ul>


          </nav>
        </div>
      </div>
    );
  }
}

export default Menu;
