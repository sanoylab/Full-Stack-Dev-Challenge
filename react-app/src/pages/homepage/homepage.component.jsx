import React, { Component } from "react";
import "./homepage.styles.css";
import AdBlock from "../../components/ad-block/ad-block.component";
import RecentItemPreview from "../../components/recent-item-preview/recent-item-preview.component";

class HomePage extends Component {
  constructor() {
    super();
    this.state = {
      ads: [],
    };
  }
  async componentDidMount() {
    const response = await fetch("https://kuralio.herokuapp.com/api/v1/ads");
    const data = await response.json();

    this.setState({ ads: data });
    console.log(this.state.ads);
  }
  render() {
    return (
      <div className="main-area">
        <AdBlock
          adOption={{
            title: "allegedly ቁጥር ፩ ዕቃ ማሻሻጫ ድህረ ገጵ in Ethiopia",
            body: "ይመዝገቡና በቀላሉ ማስታወቂያዎችን በነፃ ይለጥፉ",
            size: "container-fluid",
            bgColor: "#373373",
            bgImage:
              "https://cms.qz.com/wp-content/uploads/2017/07/rtsxwbh.jpg?quality=75&strip=all&w=1600&h=885",
            color: "#000",
          }}
        />

        <section className="wrapperAll">
          <div className="container">
            <RecentItemPreview
              title="Recent Real Estates"
              ads={this.state.ads.filter(
                (ad) => ad.category === "5f543adae54d8a0017d28eb1"
              )}
            />
            <RecentItemPreview
              title="Recent Laptops"
              ads={this.state.ads.filter(
                (ad) => ad.category === "5f503eaaba43c90017a159b2"
              )}
            />
            <RecentItemPreview
              title="Recent Furniture"
              ads={this.state.ads.filter(
                (ad) => ad.category === "5f58366cf42955001718ffbe"
              )}
            />
          </div>
          <AdBlock
            adOption={{
              title: "ይመዝገቡና በቀላሉ ማስታወቂያዎችን በነፃ ይለጥፉ",
              body: "የተለጠፉ ማስታወቂያዎችን ይፈልጉ ይመልከቱ!",
              size: "container-small",
              bgColor: "#373373",
              bgImage: "",
              color: "#fff",
            }}
          />
          <div className="container">
          <RecentItemPreview
            title="Recent Cars"
            ads={this.state.ads.filter(
              (ad) => ad.category === "5f545668e54d8a0017d28eba"
            )}
          />            
          </div>

        </section>
      </div>
    );
  }
}

export default HomePage;
