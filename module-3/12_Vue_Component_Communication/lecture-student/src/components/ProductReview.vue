<template>
  <div class="main">
    <!-- Page Header - This could be a component -->
    <product-info v-bind:name="productName" v-bind:description="productDescription"></product-info>

    <!-- Filter / data controls -->
    <p class="help">Click on a rating below to filter the list of reviews. Click on the Average Rating button to show all reviews.</p>
    <div class="well-display">
      <div class="well" @click.stop="clearFilter" title="Show all reviews">
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <!-- These should be a component -->
      <div class="well" 
           v-on:click="filterToStarRating(1)" 
           :class="{active: ratingToFilterTo === 1}" 
           title="Show 1 Star Reviews">
        <span class="amount">{{ numberOfOneStarReviews }}</span>
        1 Star Review{{ numberOfOneStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click="filterToStarRating(2)" 
           v-bind:class="{active: ratingToFilterTo === 2}"
           title="Show 2 Star Reviews">
        <span class="amount">{{ numberOfTwoStarReviews }}</span>
        2 Star Review{{ numberOfTwoStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click="filterToStarRating(3)" 
           v-bind:class="{active: ratingToFilterTo === 3}"  
           title="Show 3 Star Reviews">
        <span class="amount">{{ numberOfThreeStarReviews }}</span>
        3 Star Review{{ numberOfThreeStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click.stop="filterToStarRating(4)" 
           v-bind:class="{active: ratingToFilterTo === 4}"  
           title="Show 4 Star Reviews">
        <span class="amount">{{ numberOfFourStarReviews }}</span>
        4 Star Review{{ numberOfFourStarReviews === 1 ? '' : 's' }}
      </div>

      <div class="well" 
           v-on:click.stop="filterToStarRating(5)" 
           v-bind:class="{active: ratingToFilterTo === 5}"  
           title="Show 5 Star Reviews">
        <span class="amount">{{ numberOfFiveStarReviews }}</span>
        5 Star Review{{ numberOfFiveStarReviews === 1 ? '' : 's' }}
      </div>
    </div>

    <!-- Show Add Item -->
    <a href="#" 
       v-if="!isAddFormVisible" 
       v-on:click.prevent="isAddFormVisible = true">
       Add New Item
    </a>

    <!-- Add new items form -->
    <form v-show="isAddFormVisible"
          v-on:submit.prevent="handleSave"
      > <!-- v-show keeps it in the DOM, but adds display: none. This is ALWAYS a good idea for forms -->
      <div class="form-element">
        <label for="reviewer">Name:</label>
        <input id="reviewer" type="text" v-model="newReview.reviewer" />
      </div>
      <input type="hidden" value="YourUserIDGoesHere" />
      <div class="form-element">
        <label for="title">Title:</label>
        <input id="title" type="text" v-model="newReview.title" />
      </div>
      <div class="form-element">
        <label for="rating">Rating:</label>
        <select id="rating" v-model.number="newReview.rating">
          <option value="1">1 Star</option>
          <option value="2">2 Stars</option>
          <option value="3">3 Stars</option>
          <option value="4">4 Stars</option>
          <option value="5">5 Stars</option>
        </select>
      </div>
      <div class="form-element">
        <label for="review">Review:</label>
        <textarea id="review" v-model="newReview.review"></textarea>
      </div>
      <input type="submit" value="Save" v-bind:disabled="isSaveDisabled"> <!-- v-on:click.prevent="handleSave" -->
      <input type="button" value="Cancel" v-on:click="isAddFormVisible = false">
    </form>

    <!-- Add a link to toggle Between List and Table displays -->

    <!-- Reviews list - This should be a component -->
    <review-list-item v-for="rev in filteredReviews"
                      v-bind:key="rev.id"
                      v-bind:review="rev" />
    <div
      class="review"
      v-bind:class="{ favorited: review.favorited }"
      v-for="review in filteredReviews"
      v-bind:key="review.id"
    >
      <h4>{{ review.reviewer }}</h4>
      <div class="rating">
        <img
          src="../assets/star.png"
          v-bind:title="review.rating + ' Star Review'"
          class="ratingStar"
          v-for="n in review.rating"
          v-bind:key="n"
        />
      </div>
      <h3>{{ review.title }}</h3>

      <p>{{ review.review }}</p>

      <p>
        Favorite?
        <input type="checkbox" v-model="review.favorited" />
      </p>
    </div>
  </div>
</template>

<script>
import ProductInfo from './ProductInfo.vue'
import ReviewListItem from './ReviewListItem.vue'

export default {
  name: "product-review",
  components: {
    ProductInfo,
    ReviewListItem
  },
  data() {
    return {
      productName: "Cigar Parties for Dummies",
      productDescription:
        "Host and plan the perfect cigar party for all of your squirrelly friends.",
      isAddFormVisible: false,
      newReview: {
        rating: 1,
        title: '', // v-model="newReview.title"
        review: '',
        reviewer: ''
      },
      ratingToFilterTo: undefined,
      // This would be better off in a central store
      reviews: [
        {
          reviewer: "Malcolm Gladwell",
          title: "What a book!",
          review: "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language.",
          rating: 3,
          favorited: false
        },
        {
          reviewer: "Tim Ferriss",
          title: "Had a cigar party started in less than 4 hours.",
          review: "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
          rating: 4,
          favorited: false
        },
        {
          reviewer: "Ramit Sethi",
          title: "What every new entrepreneurs needs. A door stop.",
          review: "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
          rating: 1,
          favorited: false
        },
        {
          reviewer: "Gary Vaynerchuk",
          title: "And I thought I could write",
          review: "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
          rating: 3,
          favorited: false
        }
      ]
    };
  },
  methods: {
    handleSave(event) {
      console.log('Save was clicked!', event);

      // Identify an object representing the new review
      let reviewToAdd = this.newReview;

      // Add the new review to the reviews array (at the beginning)
      //this.reviews.unshift(reviewToAdd);
      this.reviews.splice(0, 0, reviewToAdd); // Start at beginning, delete nothing, add the review

      // Clear the form for the next addition (and prevents odd bugs in adding data multiple times)
      this.newReview = {
        rating: 1,
        title: '',
        review: '',
        reviewer: ''
      }

      // Hide the form
      this.isAddFormVisible = false;
    },
    clearFilter() {
      console.log('Clear filter clicked');
      this.ratingToFilterTo = undefined; // Clear out our filter
    },
    filterToStarRating(rating) {
      console.log('Filter to rating', rating);
      this.ratingToFilterTo = rating;
    },
  },
  computed: {
    isSaveDisabled() {
      return this.newReview.title === '';
    },
    filteredReviews() {
      return this.reviews.filter(rev => {
        return this.ratingToFilterTo === undefined || rev.rating === this.ratingToFilterTo;
      });
    },
    averageRating() {
      let sum = this.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);
      return (sum / this.reviews.length).toFixed(2);
    },
    numberOfOneStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 1);
      }, 0);
    },
    numberOfTwoStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 2);
      }, 0);
    },
    numberOfThreeStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 3);
      }, 0);
    },
    numberOfFourStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 4);
      }, 0);
    },
    numberOfFiveStarReviews() {
      return this.reviews.reduce((currentCount, review) => {
        return currentCount + (review.rating === 5);
      }, 0);
    }
  }
};
</script>

<style scoped>
div.main {
  margin: 1rem 0;
}

div.main div.well-display {
  display: flex;
  justify-content: space-around;
}

div.main div.well-display div.well {
  display: inline-block;
  width: 15%;
  border: 1px black solid;
  border-radius: 6px;
  text-align: center;
  margin: 0.25rem;
}

div.main div.well-display div.well span.amount {
  color: darkslategray;
  display: block;
  font-size: 2.5rem;
}

div.main div.review {
  border: 1px black solid;
  border-radius: 6px;
  padding: 1rem;
  margin: 10px;
}

div.main div.review.favorited {
  background-color: lightyellow;
}

div.main div.review div.rating {
  height: 2rem;
  display: inline-block;
  vertical-align: top;
  margin: 0 0.5rem;
}

div.main div.review div.rating img {
  height: 100%;
}

div.main div.review p {
  margin: 20px;
}

div.main div.review h3 {
  display: inline-block;
}

div.main div.review h4 {
  font-size: 1rem;
}

div.form-element {
  margin-top: 10px;
}
div.form-element > label {
  display: block;
}
div.form-element > input, div.form-element > select {
  height: 30px;
  width: 300px;
}
div.form-element > textarea {
  height: 60px;
  width: 300px;
}
form > input[type=button] {
  width: 100px;
}
form > input[type=submit] {
  width: 100px;
  margin-right: 10px;
}
div.well.active {
  background-color: #b5b5ff;
}
.help {
  font-size: 75%;
  color: rgb(121, 121, 121);
}
div.well:hover {
  background-color: lemonchiffon;
  cursor: pointer;
}
</style>