<template>
  <div class="background">
    <h1 class="font">Nail Artists</h1>
    <div class="card-container-fluid">
      <div class="row">
        <div class="container mt-2"></div>

        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/profile1N.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Johnie Haylie</h4>
            <p class="rating">
              Rating: {{ ratings.rating1N }}
              <span v-for="i in Math.round(ratings.rating1N)" :key="'star1-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Viver, Spain</p>

            <div class="card-btns">            
            <RouterLink class="btn" to="/profileFirstN">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile2N.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Noreen Layla</h4>
            <p class="rating">
              Rating: {{ ratings.rating2N }}
              <span v-for="i in Math.round(ratings.rating2N)" :key="'star2-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Pero, Italy</p>
            
            <div class="card-btns">            
            <RouterLink class="btn" to="/profileSecondN">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile3N.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Lotus Josie</h4>
            <p class="rating">
              Rating: {{ ratings.rating3N }}
              <span v-for="i in Math.round(ratings.rating3N)" :key="'star3-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Byske, Sweden</p>
           
            <div class="card-btns">            
            <RouterLink class="btn" to="/profileThirdN">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile4N.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Celine Melissa</h4>
            <p class="rating">
              Rating: {{ ratings.rating4N }}
              <span v-for="i in Math.round(ratings.rating4N)" :key="'star4-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Svelgen, Norway</p>
            <div class="card-btns-n">            
            <RouterLink class="btn" to="/profileFourthN">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile5N.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Jerry Finley</h4>
            <p class="rating">
              Rating: {{ ratings.rating5N }}
              <span v-for="i in Math.round(ratings.rating5N)" :key="'star5-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Oslo, Norway</p>

            <div class="card-btns-n">            
            <RouterLink class="btn" to="/profileFifthN">See Profile</RouterLink>           
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

<style src="../css/NailArtist.css" scoped></style>

<script setup>
import { ref, onMounted } from 'vue'
import { generateRandomRatings } from '@/stores/randomRatingN.js'
import { usePriceList } from '@/stores/priceListN.js'

const ratings = ref({
  rating1N: 0,
  rating2N: 0,
  rating3N: 0,
  rating4N: 0,
  rating5N: 0
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
