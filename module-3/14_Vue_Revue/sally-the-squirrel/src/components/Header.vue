<template>
  <header>
    <nav aria-label="Top Navigation">
      <router-link to="/" title="Home">
        <img
          src="../assets/images/LogoGold.png"
          alt="Sally the Squirrel's One-Stop Interview Question Shop Logo"
        />
      </router-link>
      <div>
        <NavLink displayText="Questions" navId="/Questions" />
        <NavLink displayText="Ask a Question" navId="/Ask" />
        <NavLink displayText="Our Services" navId="/Services" />
        <NavLink displayText="About Us" navId="/AboutUs" />
        <NavLink displayText="Contact Us" navId="/Contact" />
      </div>
    </nav>
  </header>
</template>

<script>
import NavLink from "./NavLink.vue";

export default {
  name: "Header",
  components: {
    NavLink
  },
  props: {},
  methods: {
    navigate(path) {
      this.$store.dispatch("navigate", path);
    }
  },
  computed: {}
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
