const express = require('express')
const router = express.Router()

const auth = require('../middleware/auth')
const Message = require('../models/message')


router.post('/:id', auth, async (req, res)=>{
    try{
        
        const message = new Message(req.body)
        message.from = req.user._id
        message.to = req.params.id
        await message.save()
        res.send(message).status(201)
    }catch(e){
        res.send(e).status(500)
    }
})

router.get('/messages',auth, async (req, res)=>{
    try{
        
        const sort ={}       
       
        if(req.query.sortBy){
            const parts = req.query.sortBy.split(':')
            sort[parts[0]]= parts[1]==='desc' ? - 1 : 1
        }  
        
        await req.user.populate({
            path:'messages',
           
            options: {
                limit: parseInt(req.query.limit),
                skip: parseInt(req.query.skip),
                sort
            }
        }).execPopulate()

        res.send(req.user.messages)
    }catch(e){
        res.send(e).status(500)
    }
})

router.delete('/message/:id',auth, async(req, res)=>{
    try{
        const msg = message.findOneAndDelete({_id: req.params.id, to: req.user._id})
        if(!msg){
            res.send().status(404)
        }
        res.send(msg)

    }catch(e){
        res.send(e).status(500)
    }
})

module.exports = router
