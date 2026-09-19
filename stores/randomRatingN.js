export function generateRandomRatings() {
    const stored = localStorage.getItem('randomRatingsN');
    if (stored) {
      return JSON.parse(stored);
    }
  
    const ratingsN = {
      rating1N: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating2N: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating3N: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating4N: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating5N: parseFloat((Math.random() * 4 + 1).toFixed(1)),
    };
  
    localStorage.setItem('randomRatingsN', JSON.stringify(ratingsN));
    return ratingsN;
  }