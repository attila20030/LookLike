<template>
  <div class="login-container">
    <div class="login-card">
      <h2 class="text-center text-light">Login</h2>
      <form @submit.prevent="handleLogin">
        <div class="input-group">
          <input type="email" v-model="email" class="form-control" placeholder="Email" />
        </div>
        <div class="input-group">
          <input type="password" v-model="password" class="form-control" placeholder="Password"  />
        </div>
        <div class="options">
       
          
          <a href="#" class="forgot-password">Forgot Password?</a>
        </div>
        <button type="submit" class="login-button">LOGIN</button>

       
      </form>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { useUserStore } from '../stores/users.js'


const login = useUserStore()

const email = ref("")
const password = ref("")

const handleLogin = () => {

  console.log(email.value)
  console.log(password.value)

  
  login.loginUser(email.value, password.value)

}

</script>

<style src="../css/Login.css"></style>
