/** @format */

///const sharp = require('sharp')
const User = require("../models/user");
const Ad = require("../models/ad");
const s3Config = require("../config/s3");

const { sendWelcomeEmail, sendCancelEmail } = require("../emails/account");
const handleErrors = (err) => {
  //console.log(err)
  let error = { name: "", email: "", password: "" };

  if (err.code === 11000) {
    error.email = "Email address is already registered";
    return error;
  }

  if (err.message.includes("User validation failed")) {
    Object.values(err.errors).forEach(({ properties }) => {
      error[properties.path] = properties.message;
    });
  }
  return error;
};

module.exports.create_user = async (req, res, next) => {
  try {
    const user = new User(req.body);
    await user.save();
    sendWelcomeEmail(user.name, user.email);
    const token = await user.generateAuthToken();
    res.send({ user, token }).status(200);
    //res.send({user}).status(201)
  } catch (err) {
    //const errors = handleErrors(err)
    //res.send({errors}).status(400);
    next(err);
  }
};
module.exports.login_user = async (req, res) => {
  try {
    const user = await User.authenticateUserLogin(
      req.body.email,
      req.body.password
    );
    const token = await user.generateAuthToken();
    res.send({ user, token }).status(201);
    //res.send({user}).status(201)
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.logout_user = async (req, res) => {
  try {
    req.user.tokens = req.user.tokens.filter((token) => {
      token.token != req.token;
    });
    await req.user.save();
    res.send(200);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.profile_user = async (req, res) => {
  try {
    res.send(req.user);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.update_user = async (req, res) => {
  try {
    const allowedUpdate = [
      "name",
      "email",
      "password",
      "address",
      "phoneNumber",
    ];
    const updates = Object.keys(req.body);
    const isAllowedUpdate = updates.every((update) =>
      allowedUpdate.includes(update)
    );
    if (!isAllowedUpdate) {
      res.send({ error: "Invalid update" });
    }
    updates.forEach((update) => (req.user[update] = req.body[update]));
    await req.user.save();
    res.send(req.user);
  } catch (e) {
    res.send(e).status(500);
  }
};

module.exports.upload_userpicture = async (req, res) => {
  //  const buffer = await sharp(req.file.buffer)
  //      .png()
  //     .resize({ width: 250, height: 250 })
  //     .toBuffer();

  req.user.avatar = req.file.buffer; // buffer;
  await req.user.save();
  res.send(req.user);
};

module.exports.get_userpicture = async (req, res) => {
  try {
    const user = await User.findById(req.params.id);
    if (!user || !user.avatar) {
      throw new Error();
    }
    res.set("Content-Type", "image/png");
    res.send(user.avatar);
  } catch (e) {
    res.send().status(404);
  }
};

module.exports.delete_userpicture = async (req, res) => {
  try {
    req.use.avatar = undefined;
    await req.user.save();
  } catch (e) {
    res.send(e).status(500);
  }
};
const deleteAds = async (_id) => {
  try {
    await Ad.findOneAndDelete({ _id });
  } catch (err) {
    console.log(err);
  }
};
module.exports.delete_user = async (req, res, next) => {
  try {
    const getAllMyAds = await Ad.find({
      postedBy: req.user._id,
    });
   
    getAllMyAds.map((ad) => {
      ad.pictures.map((pic) => {
        s3Config.destroyAdImage(pic.url.split("/").slice(-1)[0], function (
          err
        ) {
          if (err) {
            return next(err);
          }
        });
      });
      deleteAds(ad._id).then(() => {
        console.log("Deleted");
      });
    });

    await req.user.remove();
    sendCancelEmail(req.user.name, req.user.email);
    res.send(req.user);
  } catch (e) {
    res.send(e).status(500);
  }
};
