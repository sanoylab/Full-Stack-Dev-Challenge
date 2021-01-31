/** @format */

const sgMail = require("@sendgrid/mail");
require("dotenv").config();

sgMail.setApiKey(process.env.SENDGRID_API_KEY);

const sendWelcomeEmail = (name, email) => {
  sgMail.send({
    to: email,
    from: "aradalej.ethiopia@gmail.com",
    subject: "እንኳን ወደ አራዳ ልጅ ዌብ ሳይት በደህና መጡ!",
    html: `
        <table style="background-color: #fff;border-collapse:collapse; border: 1px;" width="90%" align="center">
        <tr>
        <td style="background-color: #373373; padding: 20px color: #fff;">
        <img src="https://aradalej-assets.s3.eu-central-1.amazonaws.com/Screen+Shot+2020-10-25+at+6.53.00+PM.png" width="100%"></td></tr>
        <tr>
        <td style="font-size:20px; line-height:1.5; ">
        <p><strong>ሰላምታ ከአራዳ ልጅ የቁሳቁስ ማሻሻጫ ዌብ ሳይት ይድረሳችሁ</strong></p>
        </td></tr>
        <tr><td>
        <p>አሁን ኢትዮጵያ ውስጥ በማንኛውም ሰዓትና ቦታ የሚፈልጉትን ዕቃ መግዛት፤ መሸጥ፤ መለወጥ ይችላሉ። </p>
        <p>በአራዳ ልጅ ዌብ ሳይት ላይ በነፃ ያስተዋውቁ፨</p>
        </td></tr>
        <tr><td><p>ከሰላምታ ጋር</p></td></tr>
        <tr><td><p>የአራዳ ልጅ ዴቨሮፐር</p></td></tr>
        </table>`,
  });
};

const sendCancelEmail = (name, email) => {
  sgMail.send({
    to: email,
    from: "aradalej.ethiopia@gmail.com",
    subject: "Goodbye " + name,
    text: `Please let us know why you left our service. Can't wait to see back again`,
  });
};

module.exports = {
  sendWelcomeEmail,
  sendCancelEmail,
};
