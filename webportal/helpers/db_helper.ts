import { Sequelize } from "sequelize";
import * as tedious from 'tedious';

const sequelize = new Sequelize('Order_Managment_System_Default_v1', 'test', 'test@', {
    host: 'localhost',
    server: "BERNARDOBAEZ",
    dialectModule: tedious,
    dialect: 'mssql'
  });

async function connect(){
    try {
        await sequelize.authenticate();
        console.log('Connection has been established successfully.');
      } catch (error) {
        console.error('Unable to connect to the database:', error);
      }
}

connect();

export default sequelize;