<template>
  <main>
    <section id="opening">
      <h1>Question Details</h1>

      <QuestionCard v-bind:question="question" v-bind:showEdit="false"></QuestionCard>
    </section>

    <aside class="featuredImage">
      <img
        src="../assets/images/SquirrelStone.jpg"
        title="A squirrel looking confused in a crowd of people"
      />
      <cite>
        <span>
          Photo by
          <a
            href="https://unsplash.com/@bramnaus?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >
            Bram
            Naus
          </a> on
          <a
            href="/s/photos/squirrel?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >Unsplash</a>
        </span>
      </cite>
      <blockquote>
        It's natural to ask questions. Try to make them good ones.
        <cite>
          - Sally
          the Squirrel
        </cite>
      </blockquote>
    </aside>

    <section id="questionDetails">
      <div v-show="!isBusy">
      <h2>Edit Question</h2>
      <QuestionForm v-bind:question="question" />
      <input type="button" value="Save" title="Save Changes" v-on:click="saveQuestion()" />
      <input type="button" value="Refresh" title="Refresh the question with data from the server" v-on:click="refreshFromServer()" >
      <input type="button" value="Delete" title="Deletes the question" v-on:click="deleteQuestion()" >
      </div>
      <BusySpinner v-show="isBusy" v-bind:text="busyMessage" />
    </section>
  </main>
</template>

<script>
import QuestionCard from "../components/QuestionCard.vue";
import QuestionForm from "../components/QuestionForm.vue";
import BusySpinner from "../components/BusySpinner.vue";

    function cloneQuestion(existing) {
      return { isAnswerVisible: true, ...existing }
    }

export default {
  name: "QuestionDetails",
  components: {
    QuestionCard,
    QuestionForm,
    BusySpinner
  },
  props: {
    id: String
  },
  data: () => {
    return {
      question: {},
      busyMessage: ''
    };
  },
  methods: {
    saveQuestion() {
      this.busyMessage = 'Saving...';
      this.$store.dispatch("saveQuestion", this.question);
    },
    deleteQuestion() {
      const confirmed = confirm("Are you sure you want to delete this question? This cannot be undone");
      if (confirmed) {
        this.busyMessage = 'Deleting...';
        this.$store.dispatch("deleteQuestion", this.question);
      }
    },
    refreshFromServer() {
      this.$store.dispatch("refreshQuestion", this.question.id);
    },
  },
  computed: {
    isBusy() {
      return this.$store.getters.isBusy;
    },
  },
  created() {
    // Create a clone of the existing question so we can edit it without impacting other areas
    const existing = this.$store.getters.findQuestion(this.id);
    this.question = cloneQuestion(existing);

    // Subscribe to store events (and store a reference so we can unsubscribe later)
    this.unsubscribe = this.$store.subscribe(mutation => {

      // When the question is updated and the updated question is THIS question, we need to pull the latest values from it into this form
      if (mutation.type === 'QUESTION_UPDATED') {
        const updatedQuestion = mutation.payload;
        if (updatedQuestion.id === this.question.id) {
          this.question = cloneQuestion(updatedQuestion);
        }
      }
    });
  },
  beforeDestroy() {
    this.unsubscribe();
  },
};
</script>

<style>
@import "../assets/styles/forms.css";
</style>
