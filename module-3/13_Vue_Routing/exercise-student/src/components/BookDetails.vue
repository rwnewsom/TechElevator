<template>
 <article> 
     <!-- This is hackish but it is working for now -->
    <h2 class="book-title">{{ getbook[0].title }} </h2>
    <h2 class="book-author">{{ getbook[0].author }} </h2>
    <img v-if="getbook[0].isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + getbook[0].isbn + '-M.jpg'" />
    <h2 v-if="getbook[0].read===true"> I have read this book</h2>
 </article>

</template>

<script>
export default {
    name: 'book-details',
    props: {
        book: Object,
    },
    
    
    computed: {
        getbook(){
            let id = this.$route.params.id;
            return this.$store.state.books.filter(bk => bk.isbn === id);
            }        
        }
}
</script>

<style>

.book-title {
    font-size: 1.5rem;
}

.book-author {
    font-size: 1.5rem;
}

img {
    size: 200%;
}

</style>