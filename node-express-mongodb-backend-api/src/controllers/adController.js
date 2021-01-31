/** @format */

const s3Config = require('../config/s3')
const Ad = require("../models/ad");
module.exports.create_ads = async (req, res) => {
  try {
    const ad = new Ad({
      ...req.body,
      postedBy: req.user._id,
    });
    await ad.save();
    res.send(ad).status(201);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.get_all_ads = async (req, res) => {
  try {
    const ads = await Ad.find({});
    if (!ads) {
      res.send().status(404);
    }
    res.send(ads);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.get_my_ads = async (req, res) => {
  try {
    const match = {};
    const sort = {};
    if (req.query.category) {
      match.category = req.query.category;
    }
    if (req.query.location) {
      match.location = req.query.location;
    }
    if (req.query.sortBy) {
      const parts = req.query.sortBy.split(":");
      sort[parts[0]] = parts[1] === "desc" ? -1 : 1;
    }

    //const ad = await Ad.find({postedBy: req.user._id})
    //await req.user.populate('ads').execPopulate()

    await req.user
      .populate({
        path: "ads",
        match,
        options: {
          limit: parseInt(req.query.limit),
          skip: parseInt(req.query.skip),
          sort,
        },
      })
      .execPopulate();
    res.send(req.user.ads);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.get_ad_byId = async (req, res) => {
  try {
    const match = {};
    const sort = {};
    if (req.query.category) {
      match.category = req.query.category;
    }
    if (req.query.location) {
      match.location = req.query.location;
    }
    if (req.query.sortBy) {
      const parts = req.query.sortBy.split(":");
      sort[parts[0]] = parts[1] === "desc" ? -1 : 1;
    }

    const ad = await Ad.find({ _id: req.params.id });
    // await req.user.populate('ad').execPopulate()

    res.send(ad);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.get_ad_byCategoryId = async (req, res) => {
  try {
    const match = {};
    const sort = {};
    if (req.query.category) {
      match.category = req.query.category;
    }
    if (req.query.location) {
      match.location = req.query.location;
    }
    if (req.query.sortBy) {
      const parts = req.query.sortBy.split(":");
      sort[parts[0]] = parts[1] === "desc" ? -1 : 1;
    }

    const ad = await Ad.find({ category: req.params.id });
    // await req.user.populate('ad').execPopulate()

    res.send(ad);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.update_my_ads = async (req, res) => {
  try {
    const allowedUpdate = [
      "title",
      "category",
      "description",
      "deliveryOption",
      "pictures",
      "youtubeVideo",
      "websiteURL",
      "location",
      "price",
      "phoneNumber",
      "title",
    ];
    const updates = Object.keys(req.body);
    const isAllowedUpdate = updates.every((update) =>
      allowedUpdate.includes(update)
    );
    if (!isAllowedUpdate) {
      return res.send({ error: "Invalid updates" }).status(400);
    }
    const ad = await Ad.findOne({ _id: req.params.id, postedBy: req.user._id });
    if (!ad) {
      return res.status(404).send();
    }
    updates.forEach((update) => (ad[update] = req.body[update]));
    await ad.save();
    res.send(ad);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.delete_my_ads = async (req, res, next) => {
  try {
    
    console.log(req.params.id, req.user._id);
    const getAd = await Ad.findOne({
      _id: req.params.id,
      postedBy: req.user._id,
    });
    
    getAd.pictures.map((pic) => {
      
      s3Config.destroyAdImage(pic.url.split('/').slice(-1)[0], function(err){
        if(err){
          return next(err)
        }
      })
      //pictures.push(pic.url.split('/').slice(-1)[0]);
    });
    //console.log(pictures);

    const ad = await Ad.findByIdAndDelete({
      _id: req.params.id,
      postedBy: req.user._id,
    });
    if (!ad) {
      res.send().status(404);
    }
    res.send(ad);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.upload_ad_picture = async (req, res, next) => {
  try {
    const fileURL = req.file.Location;
    
    const ad = await Ad.findOne({ _id: req.params.id });

    if (!ad) {
      next({ error: "No Ad found" });
    }

    ad.pictures.push({ url: fileURL });
    await ad.save();
    res.send(ad);
  } catch (error) {
    next(error);
  }
};

module.exports.show_ad_picture = async (req, res, next) => {
  try {
    const ad = await Ad.findOne({ _id: req.params.id });
    res.send({ id: ad._id, pictures: ad.pictures });
  } catch (error) {
    next(error);
  }
};
