<template>
  <div class="main">
    <!-- Page Header -->
    <product-info v-bind:name="$store.state.productName" 
                  v-bind:description="$store.state.productDescription" />

    <!-- Filter / data controls -->
    <p class="help">Click on a rating below to filter the list of reviews. Click on the Average Rating button to show all reviews.</p>

    <!-- Let's make this a component for review -->
    <filter-control />

    <!-- Show Add Item -->
    <a href="#" 
       v-if="!$store.state.isAddFormVisible" 
       v-on:click.prevent="$store.commit('TOGGLE_ADD_FORM_VISIBLE')">
       Add New Item
    </a>

    <!-- Add new items form -->
    <add-review-form v-show="$store.state.isAddFormVisible" />

    <!-- Reviews list - This should be a component -->
    <!-- <review-list-item v-for="rev in filteredReviews"
                      v-bind:key="rev.id"
                      v-bind:review="rev" /> -->
    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Reviewer</th>
                <th>Title</th>
                <th>Rating</th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="review of filteredReviews"
                v-bind:key="review.id">
                <td>{{ review.id }}</td>
                <td>{{ review.reviewer }}</td>
                <td>
                    <router-link v-bind:to="{name: 'review-details',
                                             params: {id: review.id}
                                            }" >
                        {{ review.title }}
                    </router-link>
                </td>
                <td>{{ review.rating }}</td>
            </tr>
        </tbody>
    </table>

  </div>
</template>

<script>
import ProductInfo from '../components/ProductInfo.vue'
import AddReviewForm from '../components/AddReviewForm.vue'
import FilterControl from '../components/FilterControl.vue'

export default {
  name: "table-view",
  components: {
    ProductInfo,
    AddReviewForm,
    FilterControl
  },
  computed: {
    filteredReviews() {
      return this.$store.state.reviews.filter(rev => {
        let filterRating = this.$store.state.ratingToFilterTo;
        return filterRating === undefined || rev.rating === filterRating;
      });
    },
  }
};
</script>

<style scoped>
div.main {
  margin: 1rem 0;
}

.help {
  font-size: 75%;
  color: rgb(121, 121, 121);
}

table {
    width: 100%;
}
</style>