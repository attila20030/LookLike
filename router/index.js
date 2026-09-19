import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import { root } from 'postcss'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/hairdresser',
      name: 'hairdresser',
      component: () => import('../views/HairDresser.vue')
    },
    {
      path: '/nailartist',
      name: 'nailartist',
      component: () => import('../views/NailArtist.vue'),
    },
    {
      path: '/piercings',
      name: 'piercings',
      component: () => import('../views/Piercings.vue'),
    },
    {
      path: '/tattooartist',
      name: 'tattooartist',
      component: () => import('../views/TattooArtist.vue'),
    },
    {
      path: '/login',
      name: 'Login',
      component: () => import('../views/Login.vue'),
    },
    {
      path: '/registration',
      name: 'registration',
      component: () => import('../views/Register.vue'),
    },
    {
      path: '/profileOne',
      name: 'profileOne',
      component: () => import('../views/Profile_1_View.vue'),
    },
    {
      path: '/profileTwo',
      name: 'profileTwo',
      component: () => import('../views/Profile_2_View.vue'),
    },
    {
      path: '/profileThree',
      name: 'profileThree',
      component: () => import('../views/Profile_3_View.vue'),
    },
    {
      path: '/profileFour',
      name: 'profileFour',
      component: () => import('../views/Profile_4_View.vue'),
    },
    {
      path: '/profileFive',
      name: 'profileFive',
      component: () => import('../views/Profile_5_View.vue'),
    },
    {
      path: '/profileFirstN',
      name: 'profileFirstN',
      component:()=>import('../views/Profile_1N_View.vue')

    },
    {
      path: '/profileSecondN',
      name: 'profileSecondN',
      component:()=>import('../views/Profile_2N_View.vue')

    },
    {
      path: '/profileThirdN',
      name: 'profileThirdN',
      component:()=>import('../views/Profile_3N_View.vue')

    },
    {
      path: '/profileFourthN',
      name: 'profileFourthN',
      component:()=>import('../views/Profile_4N_View.vue')

    },
    {
      path: '/profileFifthN',
      name: 'profileFifthN',
      component:()=>import('../views/Profile_5N_View.vue')
      

    },
    {
      path: '/profileFirstP',
      name: 'profileFirstP',
      component:()=>import('../views/Profile_1P_View.vue')
      

    },
    {
      path: '/profileSecondP',
      name: 'profileSecondP',
      component:()=>import('../views/Profile_2P_View.vue')  
      

    },
    {
      path: '/profileThirdP',
      name: 'profileThirdP',
      component:()=>import('../views/Profile_3P_View.vue')  
      

    },
    {
      path: '/profileFourthP',
      name: 'profileFourthP',
      component:()=>import('../views/Profile_4P_View.vue')  
      

    },
    {
      path: '/profileFifthP',
      name: 'profileFifthP',
      component:()=>import('../views/Profile_5P_View.vue')  
      

    },
    {
      path: '/profileFirstH',
      name: 'profileFirstH',
      component:()=>import('../views/Profile_1H_View.vue')  
      

    },
    {
      path: '/profileSecondH',
      name: 'profileSecondH',
      component:()=>import('../views/Profile_2H_View.vue')  
      

    },
    {
      path: '/profileThirdH',
      name: 'profileThirdH',
      component:()=>import('../views/Profile_3H_View.vue')
      
      

    },
    {
      path: '/profileFourthH',
      name: 'profileFourthH',
      component:()=>import('../views/Profile_4H_View.vue')

      

    },
    {
      path: '/profileFifthH',
      name: 'profileFifthH',
      component:()=>import('../views/Profile_5H_View.vue')  
      

    },
  ],
})

export default router
