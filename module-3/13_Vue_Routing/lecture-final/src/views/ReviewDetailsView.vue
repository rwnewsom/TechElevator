<template>
  <article>
      <h1>Review Details</h1>
      <review-list-item v-bind:review="review" />
  </article>
</template>

<script>
import ReviewListItem from '../components/ReviewListItem.vue'

export default {
    components: {
        ReviewListItem
    },
    data() {
        return {
            review: null // we'll grab this from Vuex
        }
    },
    created() {
        console.log('My route in Review Details is ', this.$route);
        //let routeData = this.$route.params; // {id: 4}
        let id = parseInt(this.$route.params.id);
        console.log("You want review " + id);

        this.review = this.$store.state.reviews.find(rev => rev.id === id);

        if (!this.review) {
            // Redirect to the not found page
            this.$router.push({name: 'not-found'});
        }
    }
}
</script>