<template>
    <router-link v-bind:to="navId" v-bind:class="{active: isSelected}">{{displayText}}</router-link>
</template>

<script>
export default {
  name: "NavLink",
  props: {
      navId: String,
      displayText: String
  },
  data: () => {
    return {
    };
  },
  methods: {
  },
  computed: {
    isSelected() {
      return this.$store.getters.currentView === this.navId;
    }
  }  
};
</script>

