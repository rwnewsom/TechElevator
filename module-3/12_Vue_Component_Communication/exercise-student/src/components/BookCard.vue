<template>

  <div class="card" v-bind:class="{ read: book.read}">
      
    <p class="book-title">{{book.title}}</p>
      
    <!-- Please leave <img> commented out until directed to remove open and close comment tags in the README. -->
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" /> 

    <p class="book-author">{{book.author}}</p>

    <button class="mark-read" v-if="!book.read"
            v-on:click="toggleRead"> Mark Read </button>
    <button class="mark-unread" v-if="book.read"
    v-on:click="toggleRead"> Mark Unread </button>   
   
  </div>
</template>

<script>
export default {
    props: {
        book: Object
    },
    methods: {
        toggleRead() {
            this.$store.commit('TOGGLE_READ', this.book)
        }
    }
   
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>