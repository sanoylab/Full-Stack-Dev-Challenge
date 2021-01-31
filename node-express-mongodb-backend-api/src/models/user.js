/** @format */

const mongoose = require("mongoose");
const { isEmail } = require("validator");
const bcrypt = require("bcryptjs");
const jwt = require("jsonwebtoken");
require("dotenv").config();

const userSchema = new mongoose.Schema(
  {
    name: {
      type: String,
      trim: true,
      required: [true, "Please enter your fullname"],
    },
    email: {
      type: String,
      trim: true,
      require: [true, "Please enter your email address"],
      unique: [true, "Email address is already registered"],
      validate: [isEmail, "Please enter a valid email"],
    },
    password: {
      type: String,
      trim: true,
      minlength: [6, "Minimum password length is 6 characters"],
      required: [true, "Password is required"],
    },
    address: {
      city: {
        type: String,
        trim: true,
        default: "",
      },
      kefleKetema: {
        type: String,
        trim: true,
        default: "",
      },
      woreda: {
        type: String,
        trim: true,
        default: "",
      },
      leyuBotaSeme: {
        type: String,
        trim: true,
        default: "",
      },
      geo: {
        lat: {
          type: String,
          trim: true,
          default: "",
        },
        lng: {
          type: String,
          trim: true,
          default: "",
        },
      },
    },
    phoneNumber: {
      type: String,
      default: "",
    },
    avatar: {
      type: Buffer,
      default: "",
    },
    tokens: [
      {
        token: {
          type: String,
          required: true,
        },
      },
    ],
    siteAdmin: {
      type: Boolean,
      default: false,
    },
  },
  {
    timestamps: true,
  }
);

userSchema.virtual("ads", {
  ref: "Ad",
  localField: "_id",
  foreignField: "postedBy",
});
userSchema.virtual("messages", {
  ref: "Message",
  localField: "_id",
  foreignField: "to",
});

userSchema.methods.toJSON = function () {
  const user = this;
  const userObject = user.toObject();
  delete userObject.password;
  delete userObject.tokens;
  delete userObject.avatar;
  return userObject;
};
userSchema.methods.generateAuthToken = async function () {
  const user = this;
  const token = await jwt.sign(
    { _id: user._id.toString() },
    process.env.ACCESS_TOKEN_SECRET
  );
  user.tokens = user.tokens.concat({ token });
  user.save();
  return token;
};
userSchema.statics.authenticateUserLogin = async function (email, password) {
  const user = await User.findOne({ email });
  if (!email) {
    throw new Error("Unable to login");
  }
  const isMatch = bcrypt.compare(password, user.password);
  if (!isMatch) {
    throw new Error("Unable to login");
  }
  return user;
};
userSchema.pre("save", async function (next) {
  const user = this;
  if (user.isModified("password")) {
    user.password = await bcrypt.hash(user.password, 8);
  }
  next();
});

const User = mongoose.model("User", userSchema);

module.exports = User;
