const registerApp = require("./app");
const port = process.env.PORT || 3000;
require("dotenv").config();

const main = async () => {
  const app = await registerApp();

  app.listen(port, () => {
    console.log(`Listening on Port ${port}\nGo to http://localhost:${port}`);
  });
};

main().catch((e) => console.log(`Something went wrong : Error ${e}`));
