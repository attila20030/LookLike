import { io } from 'socket.io-client'

export const socket = io('http://localhost:3000', {
  withCredentials: true
})

const API_BASE = 'http://localhost:3000'

export const loginUser = async (email, password) => {
  try {
    const response = await fetch(`${API_BASE}/login`, {
      method: 'POST',
      credentials: 'include', // nagyon fontos a JWT cookie-hoz
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({ email, password })
    })

    const data = await response.json()

    if (response.ok) {
      socket.emit('userLogin', data.user.userName)
    }

    return { success: response.ok, data }
  } catch (err) {
    return { success: false, data: { message: 'Szerver hiba vagy hálózati probléma.' } }
  }
}


export const registerUser = async (userData) => {
    try {
      const response = await fetch('http://localhost:3000/register', {
        method: 'POST',
        credentials: 'include', // fontos a JWT cookie miatt
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify(userData)
      })
  
      const data = await response.json()
  
      if (response.ok) {
        // Ha sikeres regisztráció, akkor socket.emit
        socket.emit('userLogin', data.user.userName)
      }
  
      return { success: response.ok, data }
    } catch (error) {
      return { success: false, data: { message: 'Hálózati hiba történt!' } }
    }
  }
  