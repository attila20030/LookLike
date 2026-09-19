import { createApp } from 'vue'
import { createPinia } from 'pinia'

import App from '../src/App.vue'
import router from '../src/router'

import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import "./js/breakpoints.min";


import 'v-calendar/style.css'
import { setupCalendar } from 'v-calendar'

const app = createApp(App)

app.use(createPinia())
app.use(router)

setupCalendar(app)

app.mount('#app')
