<template>
  <div id="app">
    <product-reviews />
    <!-- <ProductReviews />  -->
    <h1>Hi Vue.js</h1>
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Hello .NET Purple"/>
  </div>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import ProductReviews from './components/ProductReviews.vue'

export default {
  name: 'App',
  components: {
    HelloWorld,
    ProductReviews
  }
}
</script>

<style lang="scss">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
h1{
  color: rgb(71,11,68);
}
</style>
