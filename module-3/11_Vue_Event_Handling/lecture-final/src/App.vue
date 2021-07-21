<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png" />
    <product-review></product-review>

    <header-component message="Item 1"></header-component>
    <header-component message="Item 2"></header-component>
    <header-component message="Item 3"></header-component>
  </div>
</template>

<script>
import ProductReview from "./components/ProductReview.vue";
import HeaderComponent from "./components/HeaderComponent.vue";

export default {
  name: "app",
  components: {
    ProductReview,
    HeaderComponent
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  max-width: 800px;
  margin: 60px auto 0 auto;
}
</style>
