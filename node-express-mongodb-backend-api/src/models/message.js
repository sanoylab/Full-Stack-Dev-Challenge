const mongoose = require('mongoose')

const messageSchema = new mongoose.Schema({
    body: {
        type: String,
        trim: true,
        required: true
    },
    from: {
        type: mongoose.Schema.Types.ObjectId,
        required: true
    },
    to:{
        type: mongoose.Schema.Types.ObjectId,
        required: true
    },
    status: {
        type: Boolean,
        default: false
    }
}, {
    timestamps: true
})



const Message = mongoose.model('Message', messageSchema)

module.exports = Message