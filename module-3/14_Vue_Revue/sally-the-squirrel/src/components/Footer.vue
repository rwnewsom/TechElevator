<template>
  <footer>
    <nav aria-label="Bottom Navigation">
      <NavLink displayText="Home" navId="/" />
      <NavLink displayText="Questions" navId="/Questions" />
      <NavLink displayText="Ask a Question" navId="/Ask" />
      <NavLink displayText="Our Services" navId="/Services" />
      <NavLink displayText="About Us" navId="/AboutUs" />
      <NavLink displayText="Contact Us" navId="/Contact" />
    </nav>
    <small>Copyright &copy; {{year}} {{company}}</small>
  </footer>
</template>

<script>
import NavLink from "./NavLink.vue";

export default {
  name: "Footer",
  components: {
    NavLink
  },
  props: {
    selected: String
  },
  data: () => {
    return {
      company: "Tech Elevator, LLC"
    };
  },
  methods: {},
  computed: {
    year() {
      const d = new Date();
      return d.getFullYear();
    }
  }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
