<template>
  <div class="background">
    <h1 class="font">Hairdressers</h1>
    <div class="card-container-fluid">
      <div class="row">

        <div class="container mt-2"></div>

        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/Profile1H.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Ivan Tolly</h4>
            <p class="rating">Rating: {{ ratings.rating1H }}
              <span v-for="i in Math.round(ratings.rating1H )" :key="'star1-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Santa Fe, New Mexico</p>

            <div class="card-btns-h">            
            <RouterLink class="btn" to="/profileFirstH">See Profile</RouterLink>            
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
          <img class="card-img-top" src="../image/Profile2H.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Louisa Sienna</h4>
            <p class="rating">Rating: {{ ratings.rating2H  }}
              <span v-for="i in Math.round(ratings.rating2H )" :key="'star2-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Asheville, North Carolina</p>
            
            <div class="card-btns">            
            <RouterLink class="btn" to="/profileSecondH">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/Profile3H.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Bristol Abegail</h4>
            <p class="rating">Rating: {{ ratings.rating3H  }}
              <span v-for="i in Math.round(ratings.rating3H )" :key="'star3-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Pontestura, Italy</p>

            <div class="card-btns">            
            <RouterLink class="btn" to="/profileThirdH">See Profile</RouterLink>            
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
          <img class="card-img-top" src="../image/Profile4H.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Teresa Cat</h4>
            <p class="rating">Rating: {{ ratings.rating4H  }}
              <span v-for="i in Math.round(ratings.rating4H)" :key="'star4-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Orrville, United States</p>
            
            <div class="card-btns-h">            
            <RouterLink class="btn" to="/profileFourthH">See Profile</RouterLink>            
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
          <img class="card-img-top" src="../image/Profile5H.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Braeden Odin</h4>
            <p class="rating">Rating: {{ ratings.rating5H  }}
              <span v-for="i in Math.round(ratings.rating5H )" :key="'star5-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Heyworth, Illinois</p>
            
            <div class="card-btns">            
            <RouterLink class="btn" to="/profileFifthH">See Profile</RouterLink>            
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

<style src="../css/HairDresser.css" scoped></style>

<script setup>
import { ref, onMounted } from 'vue'
import { generateRandomRatings } from '@/stores/randomRatingH.js'
import { usePriceList } from '@/stores/priceListH.js'

const ratings = ref({
  rating1H: 0,
  rating2H: 0,
  rating3H: 0,
  rating4H: 0,
  rating5H: 0
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
