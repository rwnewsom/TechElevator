<template>
  <div id="app">
    <!-- Main user interface -->
    <div>
      <Header />

      <router-view />

      <Footer />
    </div>

  </div>
</template>

<script>
import Header from "./components/Header.vue";
import Footer from "./components/Footer.vue";

export default {
  name: "App",
  components: {
    Header,
    Footer,
  },
  data: () => {
    return {
    };
  },
  methods: {
    navigate(path) {
      console.log("navigate", path);
      this.$store.dispatch('navigate', path);
    }
  },
  computed: {
    currentView() {
      return this.$store.getters.currentView;
    }
  },
  created() {
    this.$store.dispatch('getQuestions');
  }
};
</script>

<style>
@import './assets/styles/common.css';
</style>
