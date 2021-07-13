// TODO: Install the TODO Highlight extension

// --------------------------------------------------------------------
// Code below is for LOCATIONS OF JS CODE
// --------------------------------------------------------------------

/*
    Example of a multi-line comment just like in C#
*/

// Single line comment

console.debug("Debug message from our JavaScript file!");
console.log("Log message from our JavaScript file!");
console.info("Info message from our JavaScript file!");
console.warn("Warning message from our JavaScript file!");
console.error("Error message from our JavaScript file!");

console.log('Single quotes and double quotes both work for strings');

// Console.WriteLine won't work here
// console.WriteLine("Hello World");


// TODO: Or will it?



// --------------------------------------------------------------------
// Code below is for: CONST, LET, VAR & NAMED FUNCTIONS
// --------------------------------------------------------------------

/**
 * Functions start with the word function.
 * They don't have a return type and the naming convention is camel-case.
 */
function variables() {
  // TODO: Declares a variable where the value cannot be changed
  const myUnchangingThing = 'Matt';
  // Not Allowed: myUnchangingThing = 'Batman';

  // TODO: Declares a variable whose value can be changed
  let myVariable = 42;
  myVariable = 200;
  MyVariable = 500; // Spelling / casing error here creates a new variable

  console.log(myVariable);
  console.log(MyVariable);
  // console.writeLine("Hi there");

  // TODO: Declares a variable that will always be an array
  let programmingLanguages = ["C#", "Java", "JavaScript", 42];
  console.log(programmingLanguages);

  // Declare things with var
  var daysOfWorkWeek = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday'];
  console.log(daysOfWorkWeek);

  // TODO: Demonstrate console logging

  return 4;
}

// NOTE: Everything in JavaScript is camelCase except ClassNames

/**
 * Functions can also accept parameters.
 * Notice the parameters do not have types.
 * @param {Number} param1 The first number to display
 * @param {Number} param2 The second number to display
 */
function printParameters(param1, param2) {
  // TODO: Discuss this
  console.log(`The value of param1 is ${param1}`);
  console.log("The value of param1 is " + param1);
  console.log(`The value of param2 is ${param2}`);
}

/*
########################
Function Overloading
########################

Function Overloading is not available in Javascript. 
*/

function add(num1, num2) {
  console.log('Add v1');
  return num1 + num2 + 1000;
}

function add(num1, num2, num3) {
  console.log("Add v2");
  return num1 + num2 + num3;
}

function add() {
  console.log("Add v3");
}


// --------------------------------------------------------------------
// Code below is for: EQUALITY & TRUTHY
// --------------------------------------------------------------------

// TODO: Discuss equality, == vs ===, and typeof
/**
 * Logs whether two things are double or triple equal to each other
 * @param {Number} a the first thing
 * @param {String} b the second thing
 */
function isEqualTo(a, b) {
  let isDoubleEqualTo = (a == b);
  let isTripleEqualTo = (a === b);

  console.log(a, b, '== ' + isDoubleEqualTo, '=== ' + isTripleEqualTo);

  let aType = typeof(a)
  let bType = typeof(b)
  console.log(a + ' is a ' + aType);
  console.log(b + ' is a ' + bType);

  console.log(typeof(typeof(1))); // 1 -> 'number' -> 'string'

}

// TODO: Discuss truthy / falsy
// false, 0, '', null, undefined, and NaN are always falsy everything else is truthy

function isTruthy(thing) {
  if (thing) {
    console.log('It was truthy!');
    return true;
  } else {
    console.log('It was falsy!');
    return false;
  }
}

let something = null;
if (something !== null && something !== undefined) {
  console.log("We've got something!");
}
if (something) {
  console.log("We've got something, but had to write less in our if statement!");
}

let mattsName = 'Matt';
if (mattsName) {
  console.log('Hi Matt!');
}

let myBool = true;
if (myBool === true) {
  
}


// --------------------------------------------------------------------
// Code below is for JS DATA TYPES
// --------------------------------------------------------------------

// Common data types are:

// - strings
let awesome = 'awesome';
let myVar = 'Hello world!';
myVar = "Double quotes work too";
myVar = `Templates are ${awesome}`; // "Templates are " + awesome

// - numbers
myVar = 42
myVar = 83.5

// - arrays
myVar = []
myVar = [1,2,3]
myVar = ['Batman', 'Robin']
myVar = [1, 'JS', console.log]
console.log('My array', myVar);

// - undefined
let someNewVar; // default value is undefined
console.log(someNewVar);
someNewVar = undefined;

// - object (remember JSON?)
let purchase = {
  customer: 'John Fulton',
  product: 'Ferrari',
  purchasePrice: 12050.11,
  purchaseDate: '7/12/21'
};

purchase.salesRep = 'Matt Eland';
purchase.purchasePrice *= 2.5;
purchase.purchasePrice = purchase.purchasePrice + 500.00;

console.log(purchase);

purchase.state = 'OH';

// - functions
let logFunction = console.warn;
logFunction("Hey there!", purchase);

/**
 *  Objects are simple key-value pairs
    - values can be primitive data types
    - values can be arrays
    - or they can be functions
*/
function objects() {

  // Create an object
  const person = {
    firstName: "Bill",
    lastName: "Lumbergh",
    age: 42,
    employees: [
      "Peter Gibbons",
      "Milton Waddams",
      "Samir Nagheenanajar",
      "Michael Bolton",
    ],
    address: {
      street: '42 Wallaby Way',
      state: 'OH',
      city: 'Sydney'
    }
  };

  // TODO: Log the object
  console.log(person);

  // TODO: Log the first and last name
  console.log(`The person is ${person.firstName} ${person.lastName}`);

  // TODO: Log each employee
  for (let i=0; i < person.employees.length; i++) {
    let employee = person.employees[i];
    console.log(employee);
  }

  return person;
}


// TODO: Talk functions & polymorphism

let animals = [
  {
    name: 'Cow',
    makeNoise: function() {
      return 'Mooooooo';
    }
  },
  {
    name: 'Dog',
    makeNoise: function() {
      return 'Bark bark';
    }
  }
];

for (let i = 0; i < animals.length; i++) {
  let animal = animals[i];
  console.log('The ' + animal.name + " says " + animal.makeNoise());
}

// foreach(animal of animals) {

// }




// --------------------------------------------------------------------
// Code below is for MATH AND STRINGS
// --------------------------------------------------------------------

/*
########################
Math Library
########################

A built-in `Math` object has properties and methods for mathematical constants and functions.
*/

function mathFunctions() {
  // TODO: Discuss this
  console.log("Math.PI : " + Math.PI);
  console.log("Math.LOG10E : " + Math.LOG10E);
  console.log("Math.abs(-10) : " + Math.abs(-10));
  console.log("Math.floor(1.99) : " + Math.floor(1.99));
  console.log("Math.ceil(1.01) : " + Math.ceil(1.01));
  console.log("Math.random() : " + Math.random());
}

/*
########################
String Methods
########################

The string data type has a lot of properties and methods similar to strings in Java/C#
*/

function stringFunctions(value) {
  // TODO: Discuss this
  console.log(`.length -  ${value.length}`);
  console.log(`.endsWith('World') - ${value.endsWith("World")}`);
  console.log(`.startsWith('Hello') - ${value.startsWith("Hello")}`);
  console.log(`.indexOf('Hello') - ${value.indexOf("Hello")}`);

  /*
    Other Methods
        - split(string)
        - substr(number, number)
        - substring(number, number)
        - toLowerCase()
        - trim()
        - https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String
    */
}









// --------------------------------------------------------------------
// Code below is for JS ARRAYS
// --------------------------------------------------------------------

// TODO: Add a function to filter out a specific value from an array

// TODO: Cover Array indexers

let topics = ['JS', 'C#', 'SQL', 'APIs'];

// TODO: Cover Array.Push - Appends to an array
topics.push('Vue.js'); // Inserts at end of the array

// TODO: Cover Array.Splice
let oldList = topics.slice(2); // Create a copy of topics, starting at index 2

console.log(topics)
topics.splice(2, 3, 'Java', 'REST', 'JSON'); // Removing SQL, and inserting 3 new values

// TODO: Cover Array.Shift
topics.shift(); // Removes the first element in the array ('JS')

// TODO: Cover Array.Unshift
topics.unshift('JavaScript'); // Inserts at beginning of array

// TODO: Cover Array.Slice
// TODO: Cover Array.Concat

console.log(oldList);
console.log(topics);

newList = topics.concat(['PHP', 'Python']);
console.log(newList);

function scopeTest() {
  let myBool = false

  if (myBool) {
    let iceCreamFlavor = 'Rocky Road';
  }

  console.log(iceCreamFlavor); // Will error because iceCreamFlavor is out of scope
}
