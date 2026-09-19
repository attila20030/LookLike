<template>
  <div class="background">
    <h1 class="font">Piercers</h1>
    <div class="card-container-fluid">
      <div class="row">
        <div class="container mt-2"></div>
       
        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/Profile1P.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Kip Garey</h4>
            <p class="rating">
              Rating: {{ ratings.rating1P }}
              <span v-for="i in Math.round(ratings.rating1P)" :key="'star1-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Oregon, United States of America</p>
            
            <div class="card-btns-p1">            
            <RouterLink class="btn" to="/profileFirstP">See Profile</RouterLink>           
            <div class="icon-button">
            <button @click="toggleList1" class="btn">🧾</button>
            <div v-if="showList1" class="dropdown">
              <h3 class="font-bold mb-2" style="color: black;">Price list</h3>
                <ul>
                  <li v-for="(item, i) in prices1" :key="i" style="color: #222; font-size: medium;">
                    {{ item.name }}: {{ item.price1 }}$
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
        
        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/Profile2P.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Louis Klay</h4>
            <p class="rating">
              Rating: {{ ratings.rating2P }}
              <span v-for="i in Math.round(ratings.rating2P)" :key="'star2-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Albany, New York</p>
            
            <div class="card-btns">            
            <RouterLink class="btn" to="/profileSecondP">See Profile</RouterLink>           
            <div class="icon-button">
            <button @click="toggleList2" class="btn">🧾</button>
            <div v-if="showList2" class="dropdown">
              <h3 class="font-bold mb-2" style="color: black;">Price list</h3>
                <ul>
                  <li v-for="(item, i) in prices2" :key="i" style="color: #222; font-size: medium;">
                    {{ item.name }}: {{ item.price1 }}$
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>

        
        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/Profile3P.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Lyda Jenny</h4>
            <p class="rating">
              Rating: {{ ratings.rating3P }}
              <span v-for="i in Math.round(ratings.rating3P)" :key="'star3-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Oberelz, Germany</p>

            <div class="card-btns">            
            <RouterLink class="btn" to="/profileThirdP">See Profile</RouterLink>           
            <div class="icon-button">
            <button @click="toggleList3" class="btn">🧾</button>
            <div v-if="showList3" class="dropdown">
              <h3 class="font-bold mb-2" style="color: black;">Price list</h3>
                <ul>
                  <li v-for="(item, i) in prices3" :key="i" style="color: #222; font-size: medium;">
                    {{ item.name }}: {{ item.price1 }}$
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
            
        
        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/Profile4P.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Scott Coby</h4>
            <p class="rating">
              Rating: {{ ratings.rating4P }}
              <span v-for="i in Math.round(ratings.rating4P)" :key="'star4-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Ussana, Italy</p>

            <div class="card-btns-p4">            
            <RouterLink class="btn" to="/profileFourthP">See Profile</RouterLink>           
            <div class="icon-button">
            <button @click="toggleList4" class="btn">🧾</button>
            <div v-if="showList4" class="dropdown">
              <h3 class="font-bold mb-2" style="color: black;">Price list</h3>
                <ul>
                  <li v-for="(item, i) in prices4" :key="i" style="color: #222; font-size: medium;">
                    {{ item.name }}: {{ item.price1 }}$
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>           

        
        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/Profile5P.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Maryann Ayla</h4>
            <p class="rating">
              Rating: {{ ratings.rating5P }}
              <span v-for="i in Math.round(ratings.rating5P)" :key="'star5-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Perryville, United States</p>
           
            <div class="card-btns-p5">            
            <RouterLink class="btn" to="/profileFifthP">See Profile</RouterLink>           
            <div class="icon-button">
            <button @click="toggleList5" class="btn">🧾</button>
            <div v-if="showList5" class="dropdown">
              <h3 class="font-bold mb-2" style="color: black;">Price list</h3>
                <ul>
                  <li v-for="(item, i) in prices5" :key="i" style="color: #222; font-size: medium;">
                    {{ item.name }}: {{ item.price1 }}$
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>

    </div>
  </div>
</div>
</template>

<style src="../css/Piercings.css" scoped></style>

<script setup>
import { ref, onMounted } from 'vue'
import { generateRandomRatings } from '@/stores/randomRatingP.js'
import { usePriceList } from '@/stores/priceListP.js'

const ratings = ref({
  rating1P: 0,
  rating2P: 0,
  rating3P: 0,
  rating4P: 0,
  rating5P: 0
});

onMounted(() => {
    ratings.value = generateRandomRatings();
})

const { showList: showList1, prices: prices1, toggleList: toggleList1 } = usePriceList()
const { showList: showList2, prices: prices2, toggleList: toggleList2 } = usePriceList()
const { showList: showList3, prices: prices3, toggleList: toggleList3 } = usePriceList()
const { showList: showList4, prices: prices4, toggleList: toggleList4 } = usePriceList()
const { showList: showList5, prices: prices5, toggleList: toggleList5 } = usePriceList()
</script>
