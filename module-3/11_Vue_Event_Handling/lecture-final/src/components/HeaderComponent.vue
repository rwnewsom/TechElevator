<template>
  <h1>{{ message }}</h1>
</template>

<script>
export default {
    data() {
        return {
            // message: 'Hello World'
        }
    },
    props: {
        message: String
    }
}
</script>

<style>

</style>