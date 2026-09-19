<script setup>
import { useUserStore } from '../src/stores/users.js'
import { ref } from 'vue';
import { useRouter, RouterLink } from 'vue-router';
import './js/jquery.min.js';
import './js/jquery.scrollex.min.js';
import './js/jquery.scrolly.min.js';
import './js/browser.min.js';
import './js/breakpoints.min.js';
import './js/util.js';
import './js/main.js';


const searchValue = ref('');
const router = useRouter();
const log = useUserStore()
console.log(log.isloggedin)



const logoutUser = () =>{

log.logout()



}




function handleSearch(event) {
  if (event.key !== 'Enter') return;

  const keyword = searchValue.value.toLowerCase().trim();

  switch (keyword) {
    case 'hairdresser':
      router.push('/hairdresser');
      break;
    case 'nailartist':
      router.push('/nailartist');
      break;
    case 'tattooartist':
      router.push('/tattooartist');
      break;
    case 'piercings':
      router.push('/piercings');
      break;
    case 'looklike':
      router.push('/');
      break;
    default:
      alert('Nincs ilyen oldal!');
  }

  searchValue.value = '';









}
</script>

<template>
  <header>
    <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
      <div class="container-fluid">
        <ul class="navbar-nav">
          <li class="nav-item">
            <RouterLink class="nav-link" to="/">LookLike</RouterLink>
          </li>
          <li class="nav-item">
            <RouterLink class="nav-link" to="/hairdresser">HairDresser</RouterLink>
          </li>
          <li class="nav-item">
            <RouterLink class="nav-link" to="/piercings">Piercings</RouterLink>
          </li>
          <li class="nav-item">
            <RouterLink class="nav-link" to="/tattooartist">Tattoo Artist</RouterLink>
          </li>
          <li class="nav-item">
            <RouterLink class="nav-link" to="/nailartist">Nail Artist</RouterLink>
          </li>
        </ul>

        <div id="app" class="navbar-nav ms-auto">
          <input
            type="text"
            placeholder="search"
            class="search-input"
            v-model="searchValue"
            @keyup="handleSearch"
          />
        </div>

        <ul class="navbar-nav">
          <li class="nav-item">
            <RouterLink class="nav-link" to="/registration" v-show="!log.isloggedin">Sign Up</RouterLink>
          </li>
          <li class="nav-item">
            <RouterLink class="nav-link" to="/login" v-show="!log.isloggedin">Login</RouterLink>
          </li>
          <li v-show="log.isloggedin" @click="logoutUser"><a>Logout</a></li>
        </ul>
      </div>
    </nav>
  </header>

  <router-view />

  <link rel="stylesheet" href="../src/css/main.css" />
  <noscript>
    <link rel="stylesheet" href="../src/css/noscript.css" />
  </noscript>
</template>

<style>
.search-input {
  margin-left: 30px;
  width: 200px;
  height: 30px;
  border-radius: 2px;
}
</style>
