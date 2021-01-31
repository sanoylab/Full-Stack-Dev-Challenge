import React from "react";
import { Link } from "react-router-dom";
import "./header.styles.css";
import Logo from "../../assets/logo.png";
import Search from "../search/search.component";
import Menu from "../menu/menu.component";
const Header = () => (
  <header className="header-area">
    <div className="top-header">
      <div className="container">
        <div className="top">
          <Link className="site-logo" to="/">
            <img src={Logo} />
          </Link>
          <ul className="post mobile">
            <li>አማርኛ</li>
           
            <li><button className='postad'>Sign&nbsp;In</button></li>
          </ul>
        </div>
        <Search />
       
          <ul className="post desktop">
            <li>አማርኛ</li>
           
            <li><button className='postad'>Sign&nbsp;In</button></li>
          </ul>
           
       
       
      </div>
    </div>
    <Menu />
  </header>
);

export default Header;
