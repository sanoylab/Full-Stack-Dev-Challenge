/** @format */

const express = require("express");
const router = express.Router();

const ads = require("./ad");
const categories = require("./category");
const users = require("./user");
const messages = require('./message');

router.get("/", (req, res) => {
  res.json({
    message: "AradaLej Backend API - 🥞",
  });
});
router.use("/ads", ads);
router.use("/categories", categories);
router.use("/users", users);
router.use("/messages", messages);

module.exports = router;
