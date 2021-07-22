<template>
  <div class="main">
    <!-- Page Header - This could be a component -->
    <product-info v-bind:name="$store.state.productName" 
                  v-bind:description="$store.state.productDescription" />

    <!-- Filter / data controls -->
    <p class="help">Click on a rating below to filter the list of reviews. Click on the Average Rating button to show all reviews.</p>
    <div class="well-display">
      <div class="well" @click.stop="clearFilter" title="Show all reviews">
        <span class="amount">{{ averageRating }}</span>
        Average Rating
      </div>

      <!-- These should be a component -->
      <filter-button v-bind:rating="1" />
      <filter-button v-bind:rating="2" />
      <filter-button v-bind:rating="3" />
      <filter-button v-bind:rating="4" />
      <filter-button v-bind:rating="5" />
    </div>

    <!-- Show Add Item -->
    <a href="#" 
       v-if="!$store.state.isAddFormVisible" 
       v-on:click.prevent="$store.commit('TOGGLE_ADD_FORM_VISIBLE')">
       Add New Item
    </a>

    <!-- Add new items form -->
    <add-review-form v-show="$store.state.isAddFormVisible" />

    <!-- Add a link to toggle Between List and Table displays -->

    <!-- Reviews list - This should be a component -->
    <review-list-item v-for="rev in filteredReviews"
                      v-bind:key="rev.id"
                      v-bind:review="rev" />

  </div>
</template>

<script>
import ProductInfo from './ProductInfo.vue'
import ReviewListItem from './ReviewListItem.vue'
import AddReviewForm from './AddReviewForm.vue'
import FilterButton from './FilterButton.vue'

export default {
  name: "product-review",
  components: {
    ProductInfo,
    ReviewListItem,
    AddReviewForm,
    FilterButton
  },
  methods: {
    clearFilter() {
      console.log('Clear filter clicked');

      // Commit a mutation named 'CLEAR_FILTER'. This lives in Vuex's mutations.
      this.$store.commit('CLEAR_FILTER');
    },
  },
  computed: {
    reviews() {
      // Grab the current review data out of Vuex's state
      return this.$store.state.reviews;
    },
    filteredReviews() {
      return this.reviews.filter(rev => {
        let filterRating = this.$store.state.ratingToFilterTo;
        return filterRating === undefined || rev.rating === filterRating;
      });
    },
    averageRating() {
      let sum = this.reviews.reduce((currentSum, review) => {
        return currentSum + review.rating;
      }, 0);
      return (sum / this.reviews.length).toFixed(2);
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