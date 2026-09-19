import { ref } from 'vue'

const productNames = [
  'Haircut', 'Hair coloring', 'Beard trimming', 'Balayage', 'Hair coloring',
'Hair washing', 'Hairdresser consultation', 'Children haircut', 'Bangs cutting', 'Blowdrying'
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
        price1: Math.floor(Math.random() * 1000 + 30)
      }))
    }
  }

  return {
    showList,
    prices,
    toggleList
  }
}