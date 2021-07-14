const name = 'Cigar Parties for Dummies';
const description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
const reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It <strong>should</strong> have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
    rating: 3
  }
];

// document.getElementById - find something by a specific ID. Do not use #
// document.querySelector - finds the first thing matching a CSS selector
// document.querySelectorAll - finds everything matching a CSS selector

/**
 * Add our product name to the page title
 */
function setPageTitle() {
  // Get our page page title by the id and the query the .name selector: #page-title .name
  let span = document.querySelector('#page-title .name');

  console.log(span);

  // Add the product name to the span.
  span.innerText = name;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  // Get the description paragraph
  let para = document.querySelector('.description');

  // Set the description paragraph's contents
  para.innerText = description;
}

/**
 * I will display all of the reviews on the page.
 * I will loop over the array of reviews and use some helper functions
 * to create the elements needed for our markup and add them to the DOM
 */
function displayReviews() {
  // Grab the main area of the application
  let container = document.getElementById('main');

  // For each review, build out HTML by:
  reviews.forEach(review => {
    console.log('Building review div for ', review);

    // ... creating a new HTML element (a div (ew))
    let newReviewDiv = document.createElement('div'); // ew

    // newReviewDiv.innerText = review.reviewer;
    // ... add the review class to that div
    newReviewDiv.classList.add('review');

    // ... addReviewer
    addReviewer(newReviewDiv, review.reviewer);

    // ... addRating
    addRating(newReviewDiv, review.rating);

    // ... addTitle
    addTitle(newReviewDiv, review.title);

    // ... addReview
    addReview(newReviewDiv, review.review);

    // ... add the div to the application area
    container.appendChild(newReviewDiv);
  });

  // Now that we've added these divs, let's find the rating divs
  // With these divs, add the rating class to them
  let ratingDivs = document.querySelectorAll('.review > div');
  console.log(ratingDivs);

  // For every rating container, add the rating class
  ratingDivs.forEach(div => div.classList.add('rating'));
}

/**
 * I will creating a new h4 element with the name of the reviewer and append it to
 * the parent element that is passed to me.
 *
 * @param {HTMLElement} parent: The element to append the reviewer to
 * @param {string} name The name of the reviewer
 */
function addReviewer(parent, name) {
  // Create an element that looks something like <h4>name</h4>
  let element = document.createElement('h4');
  element.innerText = name;

  // Add this element to the parent
  parent.appendChild(element);
}

/**
 * I will add an h3 element along with the review title
 * @param {HTMLElement} parent
 * @param {string} title
 */
function addTitle(parent, title) {
  // Create an element that looks something like <h3>title</h3>
  let element = document.createElement('h3');
  element.innerText = title;

  // Add this element to the parent
  parent.appendChild(element);
}

/**
 * I will add the product review
 * @param {HTMLElement} parent
 * @param {string} review
 */
function addReview(parent, review) {
  // Create an element that looks something like <p>review</p>
  // Note that this element may contain HTML content
  let element = document.createElement('p');
  element.innerHTML = review;

  // Add this element to the parent  
  parent.appendChild(element);
}

/**
 * I will add the rating div along with a star image for the number of ratings 1-5
 * @param {HTMLElement} parent
 * @param {Number} numberOfStars
 */
function addRating(parent, numberOfStars) {
  // Create a div to hold the number of stars
  let starsDiv = document.createElement('div');
  // Note: this is where a sane person would add the rating class
  //starsDiv.classList.add('rating');

  // For each star:
  console.log(numberOfStars);
  for (let i=0; i < numberOfStars; i++) {
    // ... create an image using 'img/star.png'
    let star = document.createElement('img');
    star.src = 'img/star.png';
    
    // ... add that star to the parent
    starsDiv.appendChild(star);
  }

  // Add the stars div to the parent
  parent.appendChild(starsDiv);
}

// Code to start up our application. This will change tomorrow:

// set the product reviews page title
setPageTitle();
// set the product reviews page description
setPageDescription();
// display all of the product reviews on our page
displayReviews();
