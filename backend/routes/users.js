import express from 'express'
import bcrypt from 'bcrypt'
import jwt from 'jsonwebtoken'
import { db } from '../Database/connect.js'

const router = express.Router()
 router.get('/', (req, res) => {
  res.send('Works')
 })

router.post('/register', async (req, res) => {
  const { userName, password, email, fullname, role } = req.body

  console.log(userName)
  console.log(password)
  console.log(email)
  console.log(fullname)
  console.log(role)

  if (!userName || !password || !email || !fullname || !role) {
    return res.status(400).json({ message: 'Tölts ki minden mezőt!' })
  }

  try {
    const [existingUser] = await db.execute(
      'SELECT * FROM user WHERE userName = ? OR email = ?',
      [userName, email]
    )

    if (existingUser.length > 0) {
      return res.status(400).json({ message: 'Felhasználónév vagy email már létezik!' })
    }

    const hashedPassword = await bcrypt.hash(password, 10)

    await db.execute(
      'INSERT INTO user (userName, password, email, name, role) VALUES (?, ?, ?, ?, ?)',
      [userName, hashedPassword, email, fullname, role]
    )

    const [[user]] = await db.execute('SELECT * FROM user WHERE email = ?', [email])

    const token = jwt.sign({ userID: user.userID, role: user.role }, 'secret-key')

    res.cookie('jwt', token, {
      httpOnly: true,
      maxAge: 24 * 60 * 60 * 1000 // 1 nap
    })

    res.status(201).json({
      user: {
        userID: user.userID,
        userName: user.userName,
        email: user.email,
        name: user.name,
        role: user.role
      }

    })
  } catch (err) {
    console.error(err)
    return res.status(500).json({ error: 'Regisztrációs hiba történt.' })
  }
})




router.post('/login', async (req, res) => {
  const { email, password } = req.body

  console.log(password)
  console.log(email)


  if (!email || !password) {
    return res.status(400).json({ message: 'Hiányzó adatok!' })
  }

  try {
    const [[user]] = await db.execute('SELECT * FROM user WHERE email = ?', [email])

    if (!user) {
      return res.status(404).json({ message: 'Felhasználó nem található!' })
    }

    const isPasswordValid = await bcrypt.compare(password, user.password)

    if (!isPasswordValid) {
      return res.status(401).json({ message: 'Hibás jelszó!' })
    }

    const token = jwt.sign({ userID: user.userID, role: user.role }, 'secret-key')

    res.cookie('jwt', token, {
      httpOnly: true,
      maxAge: 24 * 60 * 60 * 1000
    })

    res.status(200).json({
      user: {
        userID: user.userID,
        userName: user.userName,
        email: user.email,
        name: user.name,
        role: user.role
      }
    })
  } catch (err) {
    console.error(err)
    return res.status(500).json({ error: 'Szerver hiba történt!' })
  }
})

router.post('/logout', (req, res) => {
  res.cookie('jwt', '', { maxAge: 0 }).status(200).json({ message: 'Sikeres kijelentkezés!' })
  
})


export default router
