/**
 * All named functions will have the function keyword and
 * a name followed by parentheses.
 * 
 * @returns {number} the number 1
 */
function returnOne() {
  return 1;
}

/**
 * Functions can also take parameters. These are just variables that are filled
 * in by whoever is calling the function.
 *
 * Also, we don't *have* to return anything from the actual function.
 *
 * @param {any} value the value to print to the console
 */
function printToConsole(value) {
  console.log(value);
}

function addThings(...numbers) {
  let total = 0;
  
  for (let i = 0; i < numbers.length; i++) {
    let number = numbers[i];

    total += number;
  }

  return total;
}

function addThingsWithReduce(...numbers) {
  return numbers.reduce((total, number) => total + number, 0);
}

function multiplyThingsWithReduce(...numbers) {
  return numbers.reduce((total, number) => total * number, 1);
}

function findLargest(...numbers) {
  return numbers.reduce((largest, number) => {
    if (number > largest) {
      return number;
    } else { 
      return largest;
    }
  });
}

/**
 * Write a function called multiplyTogether that multiplies two numbers together. But 
 * what happens if we don't pass a value in? What happens if the value is not a number?
 *
 * @param {number} firstParameter the first parameter to multiply
 * @param {number} secondParameter the second parameter to multiply
 */
function multiplyTogether(firstParameter, secondParameter) {

  console.log(firstParameter, typeof(firstParameter));
  console.log(secondParameter, typeof(secondParameter));

  return firstParameter * secondParameter;
}

/**
 * This version makes sure that no parameters are ever missing. If
 * someone calls this function without parameters, we default the
 * values to 0. However, it is impossible in JavaScript to prevent
 * someone from calling this function with data that is not a number.
 * Call this function multiplyNoUndefined
 *
 * @param {number} [firstParameter=0] the first parameter to multiply
 * @param {number} [secondParameter=0] the second parameter to multiply
 */
function multiplyNoUndefined(firstParameter = 0, secondParameter = 0)
{
  return firstParameter * secondParameter;
}

let multFunction = multiplyNoUndefined;
 
let mulFunc2 = function multFuncInline(x, y) {
  return x * y;
}

let multFunc3 = function(x, y) {
  return x * y;
}

let multArrowFunc = (x, y) => {
  return x * y;
}

let multArrowOneLineFunc = (x, y) => x * y;

let addOne = (x) => x + 1;

function subtractOne(x) {
  return x - 1;
}

/**
 * Applies transformFunction to number and returns the result
 * @param {number} number 
 * @param {function} transformFunction 
 * @returns {number}
 */
function transformNumber(number, transformFunction) {
  let result = transformFunction(number); // Call the function and pass in the number

  return result;
}

// Call the transformNumber function with a number of 10
// The transform function is an arrow function that multiplies its input by 2
// The returned result will be the result of transformNumber
let result = transformNumber(10, (x) => x * 2);

/**
 * Functions can return earlier before the end of the function. This could be useful
 * in circumstances where you may not need to perform additional instructions or have to
 * handle a particular situation.
 * In this example, if the firstParameter is equal to 0, we return secondParameter times 2.
 * Observe what's printed to the console in both situations.
 * 
 * @param {number} firstParameter the first parameter
 * @param {number} secondParameter the second parameter
 */
function returnBeforeEnd(firstParameter, secondParameter) {
  console.log("This will always fire.");

  if (firstParameter == 0) {
    console.log("Returning secondParameter times two.");
    return secondParameter * 2;
  }

  //this only runs if firstParameter is NOT 0
  console.log("Returning firstParameter + secondParameter.");
  return firstParameter + secondParameter;
}

/**
 * Scope is defined as where a variable is available to be used.
 *
 * If a variable is declare inside of a block, it will only exist in
 * that block and any block underneath it. Once the block that the
 * variable was defined in ends, the variable disappears.
 */
function scopeTest() {
  // This variable will always be in scope in this function
  let inScopeInScopeTest = true;

  if (inScopeInScopeTest) {
    // this variable lives inside this block and doesn't
    // exist outside of the block
    let scopedToBlock = inScopeInScopeTest;

    console.log(scopedToBlock);
  }

  // scopedToBlock doesn't exist here so an error will be thrown
  if (inScopeInScopeTest && scopedToBlock) {
    console.log("This won't print!");
  }
}

function createSentenceFromUser(name, age, listOfQuirks = [], separator = ', ') {
  let description = `${name} is currently ${age} years old. Their quirks are: `;
  return description + listOfQuirks.join(separator);
}

/**
 * Logs things to the console, row by row
 * @param {string[]} things an array of things to log to the console
 */
function logAll(things) {

  // Normal way of doing this
  for (let i = 0; i < things.length; i++) {
    let thing = things[i]; // Get it out by its index

    console.log(thing);
  }

  // JavaScript forEach
  things.forEach((thing) => {
    console.log('Arrow function: ' + thing);
  });

  // JavaScript forEach (one-liner)
  things.forEach((thing) => console.log('One liner: ' + thing));
}

function doubleIt(num) {
  return num * 2;
}

/**
 * 
 * @param {number[]} numbers 
 */
function doubleEverything(numbers) {
  let result = [];

  for (let i = 0; i < numbers.length; i++) {
    let number = numbers[i];

    // Transform
    let transformed = doubleIt(number);

    // Add to the result
    result.push(transformed);
  }

  return result;
}

function doubleEverythingWithMap(numbers) {
  // return numbers.map((number) => number * 2);
  //return numbers.map((number) => doubleIt(number));
  return numbers.map(doubleIt);
}

/**
 * Returns a new array of numbers, only including numbers >= 10
 * @param {number[]} numbers the numbers to filter
 * @returns {number[]} an array of filtered numbers
 */
function filterSmallNumbers(numbers) {
  let result = [];

  for (let i = 0; i < numbers.length; i++) {
    let number = numbers[i];

    if (number >= 10) {
      result.push(number);
    }
  }

  return result;
}

function filterSmallNumbersWithFilter(numbers) {
  /*
  return numbers.filter((number) => {
    return number >= 10;
  });
  */
 return numbers.filter((number) => number >= 10);
}

let accounts = [
  { 
    accountId: 4001,
    accountBalance: 1000
  },
  {
    accountId: 4002,
    accountBalance: 12345
  },
  {
    accountId: 4003,
    accountBalance: 8.58
  }
];

function getAccountById(accountId) {
  for (let i = 0; i < accounts.length; i++) {
    let account = accounts[i];

    // Do we match the account we're looking for?
    if (account.accountId === accountId) {
      return account;
    }
  }

  // No account found with that account Id
  return null;
}

function findAccountById(accountId) {
  // return accounts.find((account) => {
  //   console.log(account);
  //   return account.accountId === accountId;
  // });
 return accounts.find(a => a.accountId === accountId);
}

function findAccountIndexInArrayById(accountId) {
  return accounts.findIndex(a => a.accountId === accountId);
}

/**
 * Takes an array and, using the power of anonymous functions, generates
 * their sum.
 *
 * @param {number[]} numbersToSum numbers to add up
 * @returns {number} sum of all the numbers
 */
function sumAllNumbers(numbersToSum) {
  //return numbersToSum.reduce();
}

/**
 * Takes an array and returns a new array of only numbers that are
 * multiples of 3
 *
 * @param {number[]} numbersToFilter numbers to filter through
 * @returns {number[]} a new array with only those numbers that are
 *   multiples of 3
 */
function allDivisibleByThree(numbersToFilter) {

}
