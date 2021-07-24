<template>
  <div class="book-container">

    <!-- Create a card for each book -->
    <book-card v-for="entry in books"
                v-bind:key="entry.isbn"
                v-bind:book="entry" />

  </div>
</template>

<script>
import BookCard from './BookCard.vue'

export default {
    name: 'reading-list',
    components: {
      BookCard
    },
    computed: {
      books(){
        return this.$store.state.books;
      }
    }
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>