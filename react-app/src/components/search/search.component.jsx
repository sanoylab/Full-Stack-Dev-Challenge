import React from 'react';
import './search.styles.css';
import FormInput from "../form-input/form-input.component";

const Search = () =>(
    <div className="search">
          <div className="select">
            <select name="category-list">
              <option value="volvo">All</option>
              <option value="saab">Art &amp; Collectibles</option>
              <option value="mercedes">Audio</option>
              <option value="audi">Baby Items</option>
              <option value="audi">Bikes</option>
              <option value="audi">Books</option>
              <option value="audi">Business &amp; Industrial</option>
              <option value="audi">Cameras &amp; Comcorders</option>
              <option value="audi">CD's, DV's &amp; Blue-ray</option>
              <option value="audi">Clothing</option>
              <option value="audi">Computers</option>
              <option value="audi">Computer Accessories</option>
              <option value="audi">Electronics</option>
              <option value="audi">Free Stuff</option>
              <option value="audi">Furniture</option>
              <option value="audi">Health &amp; Special Needs</option>
              <option value="audi">Hobbies &amp; Crafts</option>
              <option value="audi">Home Appliances</option>
              <option value="audi">Home - Indoor</option>
              <option value="audi">Home - Outdoor &amp; Garden</option>
              <option value="audi">Home Renovation Materials</option>
              <option value="audi">Jewlery &amp; Watches</option>
              <option value="audi">Musical Instruments</option>
              <option value="audi">Phones</option>
              <option value="audi">Sporting Goods &amp; Exercise</option>
              <option value="audi">Tools</option>
              <option value="audi">Toys &amp; Games</option>
              <option value="audi">TVs and Video</option>
              <option value="audi">Video Games &amp; Consoles</option>
              <option value="audi">Other</option>
            </select>
          </div>
          <FormInput placeHolder="Search" className="search-input"  />
          <button type='button' className='btnSearch btn btn-default'>
            <i className='fa fa-search' aria-hidden='true'></i>
          </button>
        </div>
)

export default Search;