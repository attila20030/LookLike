import express from 'express';
import mysql from 'mysql2'; 
import cors from 'cors';
import users from './routes/users.js';

const app = express();
const PORT = 3000;

app.use(express.json());

app.use(cors({
    origin: 'http://localhost:5173',
    credentials:true
}));


const dbConfig = {
    host: "localhost",
    user: "root",
    password: "",
    database: "looklike",
    port: 3306
};

let db;
const startServer = async () => {
    try {
        db = await mysql.createConnection(dbConfig);
        console.log('Database connected successfull');
        // Lekérdezés példa ("/user" végpont)
        // app.get("/user", async (req, res) => {
        //     try {
        //         const [rows] = await db.execute("SELECT * FROM user");
        //         res.json(rows);
        //     } catch (err) {
        //         console.error(err);
        //         res.status(500).json({ error: "Database error" });
        //     }
        // });

        app.use("/", users);
        app.listen(PORT, () => {
            console.log(`Server is listen on: ${PORT}`);
        });
    } catch (err) {
        console.error('connecting error', err);
    }
};

startServer();
