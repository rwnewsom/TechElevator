<template>
  <main>
      <h2>Product Reviews for {{ productName }}</h2>
      <p>We have {{reviews.length}} reviews with an average rating of
          {{ averageRating }} </p>

        <div>
            <label for ="searchText">Search Text</label>
            <input id="searchText" type="text" v-model="searchText">
        </div>
        <div>
            <label for="minRating">Minimum Rating </label>
            <select id="minRating" v-model.number="minimumRating">
                <option value="1">1</option>
                <option value="2">2</option>
                <option value="3">3</option>
                <option value="4">4</option>
                <option value="5">5</option>
            </select>
        </div>
      <article v-for="rev of filteredReviews" v-bind:key="rev.id"
      v-bind:class="{
                    suspiciousReview: rev.rating <= 2,
                    review: true
                    }">
          <h3>{{rev.reviewer}}</h3>
          <div class="starReviews">
              <img src="../assets/logo.png" 
               v-for="i of rev.rating" v-bind:key="i" />

          </div>
          <p> {{rev.text}}</p>
      </article>
  </main>
</template>

<script>
export default {  //I'm basically a class representing the component
    name: 'ProductReviews',
    data() {
        // This returns the starting data for the component
        return {
            productName: 'Sally the Squirrel\'s Interview Question Guide',
            searchText: '',
            minimumRating: 1,
            reviews: [
                {id: 1, reviewer: 'Matt Eland', rating: 5, text: 'I may be biased, but this is awesome!'},
                {id: 2, reviewer: 'John Fulton', rating: 2, text: 'Matt has no idea what he\'s talking about, but it is entertaining.'},
                {id: 3, reviewer: 'Wes Davis', rating: 1, text: "I have no idea who this Matt guy is."}
            ]
        };
    },
    computed: {
        averageRating(){
            //In vue.js 'this' refers to the component and specifically:
            // -a piece of data
            // -a computed value (derived property)
            // -a prop (property value)
            // -a function in methods (maybe?)
            if(this.reviews.length <=0){
                return 'No Reviews';
            }
            let total = 0;
            this.reviews.forEach(rev => total += rev.rating);
            return total/this.reviews.length;
        },
        filteredReviews(){
            let result = this.reviews.slice(); //copy the array
            //first, if user has typed into a searchText, do a search
            if(this.searchText){
                result = result.filter(rev => rev.text.toLowerCase().includes(this.searchText.toLowerCase()));
            }

            //if the user has set a minimumRating, filter ratings < #
            if(this.minimumRating>0){
                result = result.filter(rev => rev.rating >= this.minimumRating);
            }
            return result;
        }
    }
}
</script>

<style>
.suspiciousReview{
    color: gray;
    font-size: 80%;
}

.starReviews img {
    height: 36px;
}

</style>