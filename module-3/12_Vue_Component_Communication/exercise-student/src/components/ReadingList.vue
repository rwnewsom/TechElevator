<template>
  <div class="book-container">

    <!-- Create a card for each book -->
    <book-card v-for="book in $store.state.books"
                v-bind:key="book.isbn"
                v-bind:card="card" />

  </div>
</template>

<script>
import BookCard from './BookCard.vue'

export default {
    name: 'reading-list',
    components: {
      BookCard
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