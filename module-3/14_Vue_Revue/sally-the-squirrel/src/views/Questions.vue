<template>
  <main>
    <section id="opening">
      <h1>A Friendly Note</h1>

      <p>
        Don't worry if you can't give great answers to all or even most of these. Aim for being able to
        successfully answer around 70% or less of the questions asked of you.
      </p>

      <p>Focus on conveying a good impression as someone responsible, competent, and able to learn and grow.</p>
      <p>Remember that people are looking for someone who is:</p>
      <ul>
        <li>Professional, Responsible, and Reliable</li>
        <li>
          Knows how to program enough to work without
          <em>constant</em> help (regular check-ins are normal and
          expected)
        </li>
        <li>Able and willing to continue to learn and grow</li>
      </ul>
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
        Remember; just try to represent yourself well. You don't have to know everything.
        <cite>
          - Sally
          the Squirrel
        </cite>
      </blockquote>
    </aside>

    <section id="questionList">

      <BusySpinner v-show="isBusy" />

      <div v-show="!isBusy">
      <h2>Questions</h2>
      <p>Use the form below to search questions. Hover over a question to reveal the answer.</p>
      <div class="form-group form-inline">
        <div>
          <label for="search">Search</label>
          <input
            type="search"
            v-model="searchText"
            id="search"
            placeholder="Search questions or tags"
          />
        </div>
        <div>
          <input
            type="button"
            value="Show All"
            id="showAll"
            title="Show all answers in the question list"
            v-on:click="showAllAnswers"
          />
          <input
            type="button"
            value="Hide All"
            id="hideAll"
            title="Hide all answers in the question list"
            v-on:click="hideAllAnswers"
          />
        </div>
      </div>

      <div class="questionContainer">
        <QuestionCard v-for="q in filteredQuestions" v-bind:key="q.question" v-bind:question="q"></QuestionCard>
      </div>
</div>
    </section>
    <section id="closing" v-show="!isBusy">
      <h2>Not Enough?</h2>
      <p>
        Think we're missing something?
        <router-link to="ask">Submit a Question</router-link>&nbsp;and help us out!
      </p>
      <p>
        Don't like something you see?
        <router-link to="contact">Contact us</router-link>&nbsp;and let us know!
      </p>
    </section>
  </main>
</template>

<script>
import QuestionCard from "../components/QuestionCard.vue";
import BusySpinner from "../components/BusySpinner.vue";

export default {
  name: "Questions",
  components: {
    QuestionCard,
    BusySpinner
  },
  data: () => {
    return {
      searchText: ""
    };
  },
  methods: {
    showAllAnswers() {
      this.$store.dispatch("showAllAnswers");
    },
    hideAllAnswers() {
      this.$store.dispatch("hideAllAnswers");
    },
    doesQuestionMatchSearch(q, search) {
      // If we have no search, everything matches
      if (!search) return true;

      // Check the question text and any tags
      return (
        q.question.toLowerCase().includes(search) ||
        q.tags.some(t => t.includes(search))
      );
    }
  },
  computed: {
    filteredQuestions() {
      return this.$store.getters.questionList.filter(q =>
        this.doesQuestionMatchSearch(q, this.searchText.toLowerCase())
      );
    },
    isBusy() {
      return this.$store.getters.isBusy;
    }
  }
};
</script>

<style>
@import "../assets/styles/forms.css";

/* Styling for the list container */

.questionContainer {
  display: flex;
  flex-wrap: wrap;
  flex-direction: column;
  align-content: flex-start;
}

/* Responsiveness */

@media (min-width: 768px) {
  .questionContainer {
    flex-direction: row;
  }
}
</style>