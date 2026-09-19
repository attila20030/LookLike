import { ref } from 'vue'

const productNames = [
    'Traditional Style','Neo-Traditional Tattoo Style','New School Tattoo Style','Japanese Tattoo Style', 'Tribal Tattoo Style','Blackwork Tattoo Style',
    'Watercolour Tattoo Style','Realism Tattoo Style', 'Minimalist Tattoo Style','Fine Line Tattoo Style', 'Pointillism Tattoo Style','Cybersigilism Tattoo Style',
    'Geometric Tattoo Style', 'Trash Polka tattoo style','Patchwork Tattoo Style','Surrealism Tattoo Style','Sketch Tattoo Style','Lettering Tattoo Style',
    'Biomechanical Tattoo Style','3D Tattoo Style','Dotwork Tattoo Style','Abstract Tattoo Style','Portrait Tattoo Style','Cover-up Tattoo Style',
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
        price1: Math.floor(Math.random() * 50 + 15000)
      }))
    }
  }

  return {
    showList,
    prices,
    toggleList
  }
}