<template>
    <div>
        <div>
            <p><i class="fas fa-spinner fa-pulse fa-3x fa-spin fa-fw"></i></p>
            <h2>{{text}}</h2>
        </div>
    </div>
</template>

<script>
export default {
  name: "BusySpinner",
  components: {
  },
  props: {
      text: {
          type: String,
          default: 'Loading...'
      }
  },
  data: () => {
    return {
    };
  },
  methods: {
  },
  computed: {
  }
};
</script>

<style scoped>
div {
  display: flex;
  color: #3B3E42;
  justify-content: center;
  flex-direction: row;
}

div > div {
  display: flex;
  align-items: center;
  flex-direction: column;
}
</style>