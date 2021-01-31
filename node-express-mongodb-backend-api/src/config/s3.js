/** @format */

const aws = require("aws-sdk");

require("dotenv").config();

aws.config.update({
  secretAccessKey: process.env.AWS_SECRET_ACCESS_KEY,
  accessKeyId: process.env.AWS_ACCESS_KEY_ID,
  region: "ca-central-1",
});

exports.destroyAdImage = function (filename, callback) {
  const s3 = new aws.S3();
  var params = {
    Bucket: process.env.BUKET_NAME,
    Key: filename,
  };
  s3.deleteObject(params, function (err, data) {
    if (err) {
      console.log(err);
      callback(err);
    } else {
      callback(null);
    }
  });
};
