/** @format */

const express = require("express");
const router = express.Router();

const multer = require("multer");
const s3Storage = require("multer-sharp-s3");
const aws = require("aws-sdk");

const Ad = require("../models/ad");
const auth = require("../middleware/auth");
const {
  create_ads,
  get_all_ads,
  get_my_ads,
  get_ad_byId,
  get_ad_byCategoryId,
  update_my_ads,
  delete_my_ads,
  upload_ad_picture,
  show_ad_picture,
} = require("../controllers/adController");

//Configure Multer
require("dotenv").config();
aws.config.update({
  secretAccessKey: process.env.AWS_SECRET_ACCESS_KEY,
  accessKeyId: process.env.AWS_ACCESS_KEY_ID,
  region: "ca-central-1",
});
const s3 = new aws.S3();

// const uploadPicture = multer({
//     //dest: 'public/ad/images',
//     limits: {
//         fileSize: 1000000 // 1 MB
//     },
//     fileFilter(req, file, cb){
//         if(!file.originalname.match(/\.(jpg|jpeg|png|gif)$/)){
//             return cb(new Error('File type is not supported'))
//         }
//         cb(undefined, true)

//     }
// })
const storage = s3Storage({
  s3,
  Bucket: process.env.BUKET_NAME,

  ACL: "public-read",

  Key: function (req, file, cb) {
    cb(null, Date.now().toString());
  },
  // resize or any sharp options will ignore when uploading non image file type
  resize: {
    width: 750,
    height: 420,
  },
});

var uploadPicture = multer({
  limits: {
    fileSize: 1000000, // 1 MB
  },
  fileFilter(req, file, cb) {
    if (!file.originalname.match(/\.(jpg|jpeg|png|gif)$/)) {
      return cb(new Error("File type is not supported"));
    }

    cb(undefined, true);
  },
  storage: storage,
});

//Create new ad
/**
 * @swagger
 * /ads:
 *   post:
 *     tags:
 *     - "Ad"
 *     summary: "Create Ad"
 *     description: "A new ad can be registered using this endpoint"
 *     operationId: "createAd"
 *     produces:
 *     - "application/json"
 *     parameters:
 *     - in: "body"
 *       name: "body"
 *       description: "Created ad object"
 *       required: true
 *     responses:
 *       default:
 *         description: "successful operation"
 */
router.post("/", auth, create_ads);

//Upload Ad picture
router.post(
  "/:id/picture",
  auth,
  uploadPicture.single("picture"),
  upload_ad_picture
);
//Get Ad Picture
router.get("/:id/picture", show_ad_picture);
//Get all ads
/**
 * @swagger
 * /ads:
 *   get:
 *     tags:
 *       - "Ad"
 *     summary: "Get All Ad"
 *     description: Get all ad
 *     response:
 *       200:
 *         description: Success
 */
router.get("/", get_all_ads);
//Get my ads

/**
 * @swagger
 * /ads/me:
 *   get:
 *     tags:
 *       - "Ad"
 *     summary: "Get My Ad"
 *     description: Get My ad
 *     response:
 *       200:
 *         description: Success
 */

router.get("/me", auth, get_my_ads);
//Get ads by Id

/**
 * @swagger
 * /ads/:id:
 *   get:
 *     tags:
 *       - "Ad"
 *     summary: "Get Ad by ID"
 *     description: Get ad by Id
 *     response:
 *       200:
 *         description: Success
 */
router.get("/:id", get_ad_byId);

//Get ads by Category Id
/**
 * @swagger
 * /ads/:categoryId:
 *   get:
 *     tags:
 *       - "Ad"
 *     summary: "Get Ad by Category ID"
 *     description: Get ad by Category Id
 *     response:
 *       200:
 *         description: Success
 */
router.get("/category/:id", get_ad_byCategoryId);

//Update my ad
/**
 * @swagger
 * /ads:
 *   put:
 *     tags:
 *     - "Ad"
 *     summary: "Update ad"
 *     description: "update ad"
 *     operationId: "createUser"
 *     produces:
 *     - "application/json"
 *     parameters:
 *     - in: "body"
 *       name: "body"
 *       description: "updated ad object"
 *       required: true
 *     responses:
 *       default:
 *         description: "successful operation"
 */
router.patch("/:id", auth, update_my_ads);
//Delete my ad

/**
 * @swagger
 * /user:
 *   delete:
 *     tags:
 *     - "Ad"
 *     summary: "Delete ad"
 *     description: "ad deleted using this endpoint"
 *     operationId: "createUser"
 *     produces:
 *     - "application/json"
 *     parameters:
 *     - in: "body"
 *       name: "body"
 *       description: "Deleted ad object"
 *       required: true
 *     responses:
 *       default:
 *         description: "successful operation"
 */
router.delete("/:id", auth, delete_my_ads);

module.exports = router;
