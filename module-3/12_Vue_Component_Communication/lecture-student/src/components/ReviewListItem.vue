<template>
  <div
      class="review"
      v-bind:class="{ favorited: review.favorited }"
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

      <!--<p>
        Favorite?
        <input type="checkbox" v-model="review.favorited" />
      </p> -->
    </div>
</template>

<script>
export default {
    props: {
        review: Object
    }

}
</script>

<style>

</style>