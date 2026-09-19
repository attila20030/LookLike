<template>
  <div class="login-container">
    <div class="login-card">
      <h2 class="text-center text-light">Sign Up</h2>
      <form @submit.prevent="handleRegister">
        <div class="input-group">
          <input type="text" v-model="userName" class="form-control" placeholder="Username" />
        </div>
        <div class="input-group">
          <input type="password" v-model="password" class="form-control" placeholder="Password" />
        </div>
        <div class="input-group">
          <input type="text" v-model="fullname" class="form-control" placeholder="Full name" />
        </div>
        <div class="input-group">
          <input type="email" v-model="email" class="form-control" placeholder="Email" />
        </div>
        <div class="mb-4">
          <label for="role-select" class="text-light">Please choose</label>
          <select id="role-select" v-model="role" class="form-control">
            <option value="1" style="color: #222">User</option>
            <option value="0" style="color: #222">Service Provider</option>
          </select>
        </div>
        <button type="submit" class="login-button">REGISTRATION</button>
      </form>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { useUserStore } from '../stores/users.js'

const register = useUserStore()

const userName = ref("")
const password = ref("")
const fullname = ref("")
const email = ref("")
const role = ref("")

const handleRegister = () => {
  console.log(userName.value)
  console.log(password.value)
  console.log(fullname.value)
  console.log(email.value)
  console.log(role.value)
  register.registerUser(userName.value, password.value, email.value, fullname.value, role.value)
}
</script>

<style src="../css/Registration.css" scoped></style>

