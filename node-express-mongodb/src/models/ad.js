/** @format */

const mongoose = require("mongoose");

const adSchema = new mongoose.Schema(
  {
    category: {
      type: mongoose.Schema.Types.ObjectId,
      default: "5f2acc725c4e3e61af7d8206",
    },
    title: {
      type: String,
      trim: true,
      required: true,
    },
    description: {
      type: String,
      trim: true,
      default: "",
    },
    deliveryOption: {
      type: String,
      trim: true,
      default: "",
    },
    pictures: [{}],
    youtubeVideo: {
      type: String,
      trim: true,
      default: "",
    },
    websiteURL: {
      type: String,
      trim: true,
      default: "",
    },
    location: {
      type: String,
      trim: true,
      required: true,
      default: "",
    },
    price: {
      type: String,
      trim: true,
      default: "",
    },
    phoneNumber: {
      type: String,
      trim: true,
      default: "",
    },
    postedBy: {
      type: mongoose.Schema.Types.ObjectId,
      required: true,
    },
    expiryDate: {
      type: Date,
      default: new Date(+new Date() + 30 * 24 * 60 * 60 * 1000),
    },
  },
  {
    timestamps: true,
  }
);

const Ad = mongoose.model("Ad", adSchema);

module.exports = Ad;
