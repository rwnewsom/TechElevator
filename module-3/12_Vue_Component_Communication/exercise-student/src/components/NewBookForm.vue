<template>
<form class="new-book-form" v-on:submit.prevent="handleSave">
    <p> Enter a new book: </p>
    
    <label for="title">Title:</label>
    <input class="title-input" type="text" v-model="newBook.title" />
   
    <label for="author">Author:</label>
    <input class="author-input" type="text" v-model="newBook.author" />
    
    <label for="isbn">ISBN:</label>
    <input class="isbn-input" type="number" v-model="newBook.isbn" />
    
    <input type="submit" class="submit" value="Save">
</form>
  
</template>

<script>
export default {
    data() {
        return {
            newBook: {
                title: '',
                author: '',
                read: false,
                isbn: ''
            }
        }
    },
    methods: {
        handleSave(){
            let bookToAdd = this.newBook;
            this.$store.commit('ADD_BOOK', bookToAdd);
            //clear form for next addition and prevent odd form bugs
            this.newBook = {
                title: '',
                author: '',
                read: false,
                isbn: ''
            }
        }
    }

}
</script>

<style>
.new-book-form {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
    background-color: #aaaaaa;
    color: white;
    display: block;
}

.new-book-form p {
    font-size: 1.5rem;
}


.new-book-form label {
    float: left;
    text-align: right;
    padding-inline-start: 5px;
    margin-top: 8px;
    font-size: 1rem;
}

.new-book-form input {
    float:right;
    margin-right: 5px;
    margin-top: 5px;
}

.new-book-form .submit {
    display: block;
    margin: 0 auto;
    margin-top: 50px;
    border-radius: 5px;
}



</style>