<template>
  <div class="container">
    <div class="header-container">
      <img src="../image/p2n1g.gif" alt="" class="header-image" />
      <div class="header">
        <svg fill="#ffffff" height="18" viewBox="0 0 24 24" width="auto" xmlns="http://www.w3.org/2000/svg" class="header-icon">
          <path d="M0 0h24v24H0z" fill="none"/>
          <path d="M3 18h18v-2H3v2zm0-5h18v-2H3v2zm0-7v2h18V6H3z"/>
        </svg>
        <h1 class="main-heading">Noreen Layla</h1>
        <span v-for="tag in tags" :key="tag" class="tag">{{ tag }}</span>
        <div class="stats">
          <span class="stat-module" v-for="stat in stats" :key="stat.label">
            {{ stat.label }} <span class="stat-number">{{ stat.value }}</span>
          </span>
        </div>
      </div>
    </div>
    
    <div class="overlay-header"></div>
    
    <div class="body">
      <img src="../image/profile2N.jpg" :alt="name" class="body-image" />
      
      <div class="body-action-button-wrapper" style="position: relative;">
        <div class="body-action-button u-flex-center" @click="toggleCalendar">
          <svg fill="#ffffff" height="28" viewBox="0 0 24 24" width="28" xmlns="http://www.w3.org/2000/svg">
            <g id="book"><path d="M18 2H6c-1.1 0-2 .9-2 2v16c0 1.1.9 2 2 2h12c1.1 0 2-.9 2-2V4c0-1.1-.9-2-2-2zM6 4h5v8l-2.5-1.5L6 12V4z"/></g>
            <path d="M0 0h24v24H0z" fill="none"/>
          </svg>
        </div>
      </div>

      <span class="body-stats">Rating: {{ rating2N }}</span>
      
      <div class="body-info">
        <p v-for="paragraph in bio" :key="paragraph">{{ paragraph }}</p>
      </div>
      
      <div class="card u-clearfix">
        <span class="card-heading">Works</span>
        <ul class="card-list">
          <li v-for="work in works" :key="work"><img :src="work" alt="Works"/></li>
          <img class="work" src="../image/p2n1.jpg" alt="">
          <img class="work" src="../image/p2n2.jpg" alt="">
          <img class="work" src="../image/p2n3.jpg" alt="">
          <img class="work" src="../image/p2n4.jpg" alt="">
          <img class="work" src="../image/p2n5.jpg" alt="">
          <img class="work" src="../image/p2n6.jpg" alt="">
       </ul>
      </div>
    </div>

    <transition name="fade">
      <div v-if="calendarVisible" class="calendar-wrapper"
        style="position: absolute; top: 100px; left: 50%; transform: translateX(-50%); 
               z-index: 1000; background: white; padding: 1.5rem; border-radius: 12px; 
               box-shadow: 0 5px 15px rgba(0,0,0,0.2); width: fit-content; text-align: center;">

        <button 
          @click="toggleCalendar" 
          style="position: absolute; top: 10px; right: 10px; background: transparent; 
                 border: none; font-size: 20px; font-weight: bold; color: red; cursor: pointer;"
          aria-label="Bezárás">
          &times;
        </button>

        <v-date-picker
          v-model="date"
          is-required
          mode="dateTime"
          color="purple"
          is24hr
          :attributes="highlightedDates"
        />

        <div v-if="selectedDayReservations.length > 0" class="reserved-times" style="margin-top: 1rem;">
          <h4 style="margin-bottom: 0.5rem; color: #222;">Már foglalt időpontok:</h4>
          <ul style="list-style: none; padding: 0; color: #222;">
            <li v-for="(time, index) in selectedDayReservations" :key="index">🕒{{ time }}</li>
          </ul>
        </div>

        <p class="error" v-if="errorMessage" style="color: #b00020; font-weight: bold; margin-top: 0.5rem;">
          {{ errorMessage }}
        </p>

        <div v-if="errorMessage && selectedDayReservations.length > 0" class="reserved-times" 
          style="text-align: center; margin-top: 0.5rem; background: #f8f8f8; color: #222; 
                 padding: 1rem; border-radius: 8px; box-shadow: 0 2px 6px rgba(0,0,0,0.1);">
          <p style="font-weight: bold; color: #d32f2f;">Már foglalt időpontok erre a napra:</p>
          <ul style="padding: 0; list-style: none;">
            <li v-for="(time, index) in selectedDayReservations" :key="index" style="margin: 4px 0;">
              🕒 {{ time }}
            </li>
          </ul>
        </div>

        <p class="selected-date" style="margin-top: 0.5rem; color: #222;">
          Kiválasztott: {{ formattedDate }}
        </p>

        <button @click="saveDate" class="btn" style="margin-top: 1rem;">Mentés</button>
      </div>
    </transition>
  </div>
</template>

<script>
import { DatePicker } from 'v-calendar'
import 'v-calendar/style.css'
import { ref, onMounted } from 'vue'
import { generateRandomRatings } from '@/stores/randomRatingN.js';

export default {
  components: {
    VDatePicker: DatePicker
  },
  
  data() {
    return {
      name: "Noreen Layla",
      tags: ["Nail Artist"],
      stats: [
        { label: "Contact: ", value: "NoYa@email.org" },
        { label: "Location: ", value: "Pero" },
        { label: "Work Place: ", value: "TinkArt" }
      ],
      profileImage: "../image/profile2N.jpg",
      bio: [
        "Creating dreamy nail art that sparkles as brightly as my passion! 💅💖 Let’s turn your nails into tiny masterpieces! "
      ],
      works: [],
      calendarVisible: false,
      date: null,
      savedDates: [], 
      errorMessage: "",        
      rating2N: 0,
    };
  },
  computed: {
    formattedDate() {
      return this.date ? new Date(this.date).toLocaleString() : 'Nincs dátum';
    },
    selectedDayReservations() {
      if (!this.date) return [];

      const selectedDay = new Date(this.date).toISOString().split('T')[0];
      return this.savedDates
        .filter(d => d.startsWith(selectedDay))
        .map(d => new Date(d).toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' }));
    },
    highlightedDates() {
      return this.savedDates.map(d => ({
        key: d,
        highlight: {
          color: 'green',
          fillMode: 'light',
        },
        dates: new Date(d)
      }));
    }
  },
  methods: {
    toggleCalendar() {
      this.calendarVisible = !this.calendarVisible;
    },
    saveDate() {
      if (!this.date) {
        this.errorMessage = 'Kérlek válassz ki egy időpontot!';
        return;
      }

      const selected = new Date(this.date).toISOString();
      if (this.savedDates.includes(selected)) {
        this.errorMessage = 'Ez az időpont már foglalt!';
        return;
      }

      this.savedDates.push(selected);
      this.date = null;
      this.errorMessage = '';   
    },
  },
  mounted() {
    const ratings = generateRandomRatings();
    this.rating2N = ratings.rating2N;
  },
};
</script>

<style src="../css/Profile_N.css" scoped></style>
