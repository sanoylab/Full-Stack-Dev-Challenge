const mongoose = require('mongoose');
require('dotenv').config();

mongoose.connect(process.env.DB_URL, {
    useCreateIndex: true,
    useNewUrlParser: true,
    useUnifiedTopology: true
})
