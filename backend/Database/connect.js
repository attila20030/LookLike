import express from "express";
import mysql from 'mysql2/promise.js';

//const app = express();
const db = await mysql.createConnection({
    host:"localhost",
    user:"root",
    password:"",
    database:"looklike",
    port:"3306"
})

export {db}