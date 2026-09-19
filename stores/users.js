import { ref, computed } from 'vue'
import { defineStore } from 'pinia'
import axios from 'axios'
import router from '@/router'

export const useUserStore = defineStore('userStore', () => {

    const tomb = ref([])
    const isloggedin = ref(false)
    const user = ref([])

//    const user = ref([])
//     const isLoggedIn = ref(false) 

    const registerUser = async (userName, password,email,fullname,role)=>{
        try{
        const response = await axios.post('http://localhost:3000/register',{userName,password,email,fullname,role})
        tomb.value = response.data
        console.log(response.status)
        console.log(tomb.value)
        console.log(tomb.value.user.role)

        if(response.status === 201)
        {
            isloggedin.value = true
        }

        if(tomb.value.user.role === 0)
        {
            router.push('profileFour')
        }
        else{
            router.push('/')
        }}
        catch(err)
        {
            console.log(err.status)
        }
    }




    const logout = async ()=>{


        try {
            const response = await axios.post('http://localhost:3000/logout', {},{ withCredentials: true }
        )


            if (response.status === 200) {
                isloggedin.value = false

         }


         } catch (err) {
             console.error("logout hiba")
         }

    }






     const loginUser = async (email, password) => {
        try {
            const response = await axios.post('http://localhost:3000/login', {
                email,
               password
            },{ withCredentials: true }
        )
            user.value = response.data
            console.log(response.status)
            console.log(user.value)

            if (response.status === 200) {
                isloggedin.value = true
                console.log(isloggedin.value)
                
                //localStorage.setItem('token', user.value.token) 

               if (user.value?.role === 0) {
                     router.push('profileFour')
                 } else {
                    router.push('/')
                }
         }
         } catch (err) {
             console.error("Bejelentkezési hiba:", err.response?.status || err.message)
         }
 }

  return { registerUser ,loginUser ,logout, isloggedin} 
})

