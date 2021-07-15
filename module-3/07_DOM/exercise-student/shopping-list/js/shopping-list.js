// add pageTitle
let pageTitle = 'My Shopping List';

// add groceries
let groceries = ['bread','beer','cheese','linguini','ramen','eggs','mushrooms','bagels','apples','yogurt'];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  let span = document.querySelector('#title');

  //console.log(span);

  // Add the product name to the span.
  span.innerText = pageTitle;

} 

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  let container = document.getElementById('groceries');

  groceries.forEach(item => {
    console.log('adding to list: ', item);
    //add list item!
  let element = document.createElement('li');
  element.innerHTML = item;

  // Add this element to the parent  
  container.appendChild(element);

  });
}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  let shoppingList = document.querySelectorAll('#groceries > li');

  shoppingList.forEach(li => li.classList.add('completed'));
}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
