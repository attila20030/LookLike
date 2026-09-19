import { ref } from 'vue'

const productNames = [
    'Acrylics','Basic manicure','Dip powder','Gel manicure','French manicure','Shellac','Hard Gel','American manicure','Gel extensions','Paraffin manicure','Polygel',
    'Reverse French manicure'
    
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
        price1: Math.floor(Math.random() * 50 + 20)
      }))
    }
  }

  return {
    showList,
    prices,
    toggleList
  }
}