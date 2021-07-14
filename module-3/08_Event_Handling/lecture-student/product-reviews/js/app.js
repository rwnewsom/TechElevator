const name = 'Cigar Parties for Dummies';
let description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
let reviews = [
  {
    reviewer: 'Malcolm Gladwell',
    title: 'What a book!',
    review:
      "It certainly is a book. I mean, I can see that. Pages kept together with glue (I hope that's glue) and there's writing on it, in some language.",
    rating: 3
  }
];

/**
 * Add our product name to the page title
 * Get our page page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerHTML = name;
}

/**
 * Add our product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerHTML = description;
}

/**
 * I will display all of the reviews in the reviews array
 */
function displayReviews() {
  if ('content' in document.createElement('template')) {
    reviews.forEach((review) => {
      displayReview(review);
    });
  } else {
    console.error('Your browser does not support templates');
  }
}

/**
 * Displays all reviews on the page
 * @param {Object} review The review to display
 */
function displayReview(review) {
  const main = document.getElementById('main');

  // This grabs a template out of the HTML and clones it, then selects the template to customize it
  const clonedNode = document.getElementById('review-template').content.cloneNode(true);
  clonedNode.querySelector('h4').innerHTML = review.reviewer;
  clonedNode.querySelector('h3').innerHTML = review.title;
  clonedNode.querySelector('p').innerHTML = review.review;

  // there will always be 1 star because it is a part of the template
  for (let i = 1; i < review.rating; ++i) {
    const img = clonedNode.querySelector('img').cloneNode();
    clonedNode.querySelector('.rating').appendChild(img);
  }
  
  main.appendChild(clonedNode);
}

/**
 * I will show / hide the add review form
 */
function showHideForm() {
  const form = document.querySelector('form');
  const btn = document.getElementById('btnToggleForm');

  if (form.classList.contains('d-none')) {
    form.classList.remove('d-none');
    btn.innerText = 'Hide Form';
    document.getElementById('name').focus();
  } else {
    resetFormValues();
    form.classList.add('d-none');
    btn.innerText = 'Add Review';
  }
}

/**
 * I will reset all of the values in the form.
 */
function resetFormValues() {
  const form = document.querySelector('form');
  const inputs = form.querySelectorAll('input');
  inputs.forEach((input) => {
    input.value = '';
  });
  document.getElementById('rating').value = 1;
  document.getElementById('review').value = '';
}

// LECTURE STARTS HERE ---------------------------------------------------------------

function initialize() {
  // set the product reviews page title
  setPageTitle();

  // set the product reviews page description
  setPageDescription();

  // display all of the product reviews on our page
  displayReviews();

  // -----------------------------------------------

  // When the user clicks on btnToggleForm, call showHideForm

  // When the user clicks btnSaveReview, call saveReview

  // -----------------------------------------------

  // When the user double clicks the description paragraph, 
  // call showDescriptionEdit and pass it the event

  // When the user's mouse leaves the input with an ID of inputDesc, 
  // call exitDescriptionEdit without saving

  // When the user presses a key on the input with an ID of inputDesc, 
  // check for enter and escape and call exitDescriptionEdit

  // ------------------------------------------------

  // Add a click listener for when the user clicks the body element
}

/**
 * I will save the review that was added using the add review from
 */
function saveReview() {
  // Get the value of the name, title, review, and rating

  // Create a new review object with these values for reviewer, 
  // title, review, and rating

  // Add the new object to reviews

  // Call displayReview with the new review as a parameter

  // Call showHideForm to toggle the form visibility
}

/**
 * Take an event on the description and swap out the description for a text box.
 *
 * @param {Event} event the event object
 */
function showDescriptionEdit(event) {
  const target = event.target;

  const textBox = target.nextElementSibling;
  textBox.value = description;
  textBox.classList.remove('d-none');

  target.classList.add('d-none');

  textBox.focus();
}

/**
 * Take an event on the text box and set the description to the contents
 * of the text box and then hide the text box and show the description.
 *
 * @param {Event} event the event object representing the description we're editing
 * @param {Boolean} save should we save the description text
 */
function exitDescriptionEdit(event, save) {
  const target = null; // TODO: This comes from the event

  if (!target) return; // this line can go once target is set

  const desc = target.previousElementSibling;

  // If we're saving, get the new value and set that into description and desc
  if (save) {
  }

  target.classList.add('d-none');
  desc.classList.remove('d-none');
}

// TODO: Only call initialize when the DOM is ready
initialize();
