<template>
    <header>
        <h2>Product Reviews for {{ name }}</h2>
        <p class="description">{{ description }}</p>
    </header>
</template>

<script>
export default {
    data(){
        return {
        }
    },
    props: {
        name: String,
        description: String,
    }

}
</script>

<style>

</style>