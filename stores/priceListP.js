import { ref } from 'vue'

const productNames = [
    'Tragus','Daith','Nasal septum','Rook','Tongue piercing','Ear piercings','Eyebrow piercing','Belly piercing','Conch','Helix','Labret','Nose piercing','Eyebrow','Lip piercing',
    'Nostril piercing','Angel bites','Anti-tragus','Bridge','Cheek piercing','Conch piercing','Earlobe','Forward helix'
]

export function usePriceList() {
  const showList = ref(false)
  const prices = ref([])

  function toggleList() {
    showList.value = !showList.value
    if (showList.value) {
      const shuffled = productNames.sort(() => 0.5 - Math.random()).slice(0, 5)
      prices.value = shuffled.map(name => ({
        name,
        price1: Math.floor(Math.random() * 30 + 80)
      }))
    }
  }

  return {
    showList,
    prices,
    toggleList
  }
}