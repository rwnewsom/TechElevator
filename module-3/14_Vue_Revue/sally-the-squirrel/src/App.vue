<template>
  <div id="app">
    <!-- TODO: This is a hack until we get to Vuex in week 11 and then later, Routing in week 12 
    <div class="form-group">
      <input type="button" value="Home" v-on:click="navigate('Home')" />
      <input type="button" value="Questions" v-on:click="navigate('Questions')" />
      <input type="button" value="Ask a Question" v-on:click="navigate('Ask')" />
      <input type="button" value="Services" v-on:click="navigate('Services')" />
      <input type="button" value="About" v-on:click="navigate('AboutUs')" />
      <input type="button" value="Contact" v-on:click="navigate('Contact')" />
    </div>
    -->

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
