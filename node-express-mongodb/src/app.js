/** @format */

const express = require("express");
const path = require("path");
const cors = require("cors");
const swaggerJsDoc = require("swagger-jsdoc");
const swaggerUi = require("swagger-ui-express");

require("./db/connection");
require("dotenv").config();
const errors = require("./error-middleware");
const PORT = process.env.PORT;

//Routers
//const userRouter = require('./routers/user')
//const categoryRouter = require('./routers/category')
//const adRouter = require('./routers/ad')
//const messageRouter = require('./routers/message')

const router = require("./routers/index");

const app = express();

const options = {
  definition: {
    openapi: "3.0.0",
    info: {
      title: "AradaLej Online Ad Posting App",
      description:
        "This is the backend api for the AradaLej online Ad Posting App",
      termsOfService: "http://aradalej.com/terms/",
      contact: {
        name: "API Support",
        url: "http://www.aradalej.com/support",
        email: "aradalej.ethiopia@gmail.com",
      },
      license: {
        name: "Apache 2.0",
        url: "https://www.apache.org/licenses/LICENSE-2.0.html",
      },
      version: "1.0.1",
      servers: ["http://localhost:3000"],
    },
  },
  apis: ["src/routers/*.js"],
};

const swaggerSpec = swaggerJsDoc(options);

//App level middlewares
app.use(cors());
app.use(express.json());
app.use("/api/v1", router);

//app.use(userRouter)
//app.use(categoryRouter)
//app.use(adRouter)
//app.use(messageRouter)
app.use("/api/v1/docs", swaggerUi.serve, swaggerUi.setup(swaggerSpec));

app.use(errors.notFound);
app.use(errors.errorHandler);

app.listen(PORT, () => {
  console.log(`Server is started on port ${PORT}`);
});
