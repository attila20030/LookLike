<template>
  <div class="background">
    <h1 class="font">Tattoo Artists</h1>
    <div class="card-container-fluid">
      <div class="row">
        <div class="container mt-2"></div>

        <div class="card col-sm-6 col-md-4 col-lg-3">
          <img class="card-img-top" src="../image/profile1.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Briar Jaxton</h4>
            <p class="rating">
              Rating: {{ ratings.rating1T }}
              <span v-for="i in Math.round(ratings.rating1T)" :key="'star1-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Asheville, North Carolina</p>
            
            <div class="card-btns-t">            
            <RouterLink class="btn" to="/profileOne">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile2.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Elicia Unique</h4>
            <p class="rating">
              Rating: {{ ratings.rating2T }}
              <span v-for="i in Math.round(ratings.rating2T)" :key="'star2-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Wolfville, Canada</p>
            
            <div class="card-btns-t">            
            <RouterLink class="btn" to="/profileTwo">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile3.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Rose Ricki</h4>
            <p class="rating">
              Rating: {{ ratings.rating3T }}
              <span v-for="i in Math.round(ratings.rating3T)" :key="'star3-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Amsterdam, Netherlands</p>

            <div class="card-btns">            
            <RouterLink class="btn" to="/profileThree">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile4.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Doran Graysen</h4>
            <p class="rating">
              Rating: {{ ratings.rating4T}}
              <span v-for="i in Math.round(ratings.rating4T)" :key="'star4-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Toronto, Canada</p>
            
            <div class="card-btns-t">            
            <RouterLink class="btn" to="/profileFour">See Profile</RouterLink>           
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
          <img class="card-img-top" src="../image/profile5.jpg" alt="Card image" style="width:90%">
          <div class="card-body">
            <h4 class="card-title">Tim Joby</h4>
            <p class="rating">
              Rating: {{ ratings.rating5T }}
              <span v-for="i in Math.round(ratings.rating5T)" :key="'star5-' + i" class="star-icon">★</span>
            </p>
            <p class="location">Location: Incheon, South Korea</p>
           
            <div class="card-btns">            
            <RouterLink class="btn" to="/profileFive">See Profile</RouterLink>           
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

<style src="../css/Tattoo_Artist.css" scoped></style>

<script setup>
import { ref, onMounted } from 'vue';
import { generateRandomRatings } from '@/stores/randomRatingT.js';
import { usePriceList } from '@/stores/priceListT.js'

const ratings = ref({
  rating1T: 0,
  rating2T: 0,
  rating3T: 0,
  rating4T: 0,
  rating5T: 0
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
