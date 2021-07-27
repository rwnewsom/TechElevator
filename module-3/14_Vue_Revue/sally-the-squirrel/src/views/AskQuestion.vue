<template>
  <main>
    <aside class="featuredImage">
      <img src="../assets/images/Contact.jpg" alt="A squirrel standing and staring attentively" />
      <cite>
        <span>
          Photo by
          <a
            href="https://unsplash.com/@alexxsvch?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >
            Alexey
            Savchenko
          </a> on
          <a
            href="/s/photos/squirrel-letter?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >Unsplash</a>
        </span>
      </cite>
      <blockquote>
        What? We didn't have enough questions already?
        <cite>
          - Sally
          the Squirrel
        </cite>
      </blockquote>
    </aside>
    <section id="opening">
      <h1>Ask a Question</h1>
      <form @submit.prevent="onFormSubmitted()" v-show="!isBusy">
        <QuestionForm v-bind:question="question" />

        <input type="submit" />
      </form>
    </section>
    <BusySpinner v-show="isBusy" text="Saving..." />
  </main>
</template>

<script>
import QuestionForm from "../components/QuestionForm.vue";
import BusySpinner from "../components/BusySpinner.vue";

export default {
  name: "AskQuestion",
  components: {
    QuestionForm,
    BusySpinner
  },
  data: () => {
    return {
      question: {
        question: "",
        answer: "",
        difficulty: 1,
        learnMoreUrl: "",
        categories: [],
        isCorrect: undefined,
        id: -1,
        isAnswerVisible: false
      },
      isSaving: false
    };
  },
  computed: {
    isBusy() {
      return this.$store.getters.isBusy;
    }
  },
  methods: {
    onFormSubmitted() {
      this.$store.dispatch("addQuestion", this.question);
    }
  }
};
</script>

<style>
@import "../assets/styles/forms.css";
</style>