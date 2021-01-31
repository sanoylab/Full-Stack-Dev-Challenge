const express = require('express')
const router = express.Router()

const Category = require('../models/category')
const multer = require('multer')

router.post('/', async (req, res)=>{
    try{
        const category = new Category(req.body)
        if(!category){
            res.send().status(404)
        }
        await category.save()
        res.send(category).status(201)
    }catch(e){
        res.send(e).status(500)
    }
})
/**
 * @swagger
 * /categories:
 *   get:
 *     tags:
 *       - "Category"
 *     description: Gets all categories
 *     response:
 *       200:
 *         description: Success
 */
router.get('/', async (req, res)=>{
    try{
        const categories = await Category.find({})
        res.send(categories)
    }catch(e){
        res.send(e).status(500)
    }
})

const upload = multer();

router.post('/:id', upload.single(), (req, res)=>{

})

module.exports = router