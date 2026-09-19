export function generateRandomRatings() {
    const stored = localStorage.getItem('randomRatingsH');
    if (stored) {
      return JSON.parse(stored);
    }
  
    const ratingsH = {
      rating1H: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating2H: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating3H: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating4H: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating5H: parseFloat((Math.random() * 4 + 1).toFixed(1)),
    };
  
    localStorage.setItem('randomRatingsH', JSON.stringify(ratingsH));
    return ratingsH;
  }