export function generateRandomRatings() {
    const stored = localStorage.getItem('randomRatingsP');
    if (stored) {
      return JSON.parse(stored);
    }
  
    const ratingsP = {
      rating1P: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating2P: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating3P: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating4P: parseFloat((Math.random() * 4 + 1).toFixed(1)),
      rating5P: parseFloat((Math.random() * 4 + 1).toFixed(1)),
    };
  
    localStorage.setItem('randomRatingsP', JSON.stringify(ratingsP));
    return ratingsP;
  }