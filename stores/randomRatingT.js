export function generateRandomRatings() {
    const stored = localStorage.getItem('randomRatingsT');
    if (stored) {
      return JSON.parse(stored);
    }
  
    const ratingsT = {
      rating1T: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating2T: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating3T: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating4T: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating5T: parseFloat((Math.random() * 4 + 1).toFixed(1)),
    };
  
    localStorage.setItem('randomRatingsT', JSON.stringify(ratingsT));
    return ratingsT;
  }