<template>
  <article
    v-on:dblclick="toggleAnswer"
    v-bind:class="{ blur: !question.isAnswerVisible, 
                    correct: question.isCorrect == true, 
                    incorrect: question.isCorrect == false}"
  >
    <div class="question">{{question.question}}</div>
    <div class="answer" v-on:click="showAnswer">{{question.answer}}</div>
    <div class="questionFooter">
      <div class="visibilityCommands">
        <a
          class="showAnswer"
          v-on:click="showAnswer"
          v-show="!question.isAnswerVisible"
          title="Show Answer"
        >
          <i class="fas fa-eye fa-lg"></i>
        </a>
        <a
          class="hideAnswer"
          v-on:click="hideAnswer"
          v-show="question.isAnswerVisible"
          title="Hide Answer"
        >
          <i class="fas fa-eye-slash fa-lg"></i>
        </a>
        <router-link v-bind:to="editUrl" v-show="isEditVisible">
          <i class="fas fa-edit fa-lg" title="Edit Question"></i>
        </router-link>
      </div>
      <div class="gradingCommands">
        <a
          class="markCorrect"
          v-on:click="markCorrect"
          v-show="isMarkCorrectVisible"
          title="Mark Correct"
        >
          <i class="fas fa-thumbs-up fa-lg"></i>
        </a>
        <a
          class="markIncorrect"
          v-on:click="markIncorrect"
          v-show="isMarkIncorrectVisible"
          title="Mark Incorrect"
        >
          <i class="fas fa-thumbs-down fa-lg"></i>
        </a>
      </div>
    </div>
  </article>
</template>

<script>
export default {
  name: "QuestionCard",
  props: {
    showEdit: {
      type: Boolean,
      default: true
    },
    question: {
      type: Object,
      default: function() {
        return {
          question: "Test Data",
          answer:
            "If you see this on a web page, you likely forgot to set the 'question' prop of the QuestionCard",
          tags: ["testing"],
          learnMoreUrl: "https://google.com",
          difficulty: 1,
          isCorrect: undefined,
          isAnswerVisible: false
        };
      }
    }
  },
  data: () => {
    return {};
  },
  methods: {
    markCorrect() {
      this.$store.dispatch("markCorrect", this.question);
    },
    markIncorrect() {
      this.$store.dispatch("markIncorrect", this.question);
    },
    showAnswer() {
      this.$store.dispatch("showAnswer", this.question);
    },
    hideAnswer() {
      this.$store.dispatch("hideAnswer", this.question);
    },
    toggleAnswer() {
      this.$store.dispatch("toggleCorrect", this.question);
    }
  },
  computed: {
    isMarkCorrectVisible() {
      return this.question.isAnswerVisible && this.question.isCorrect != true;
    },
    isMarkIncorrectVisible() {
      return this.question.isAnswerVisible && this.question.isCorrect != false;
    },
    isEditVisible() {
      return this.question.isAnswerVisible && this.showEdit;
    },
    editUrl() {
      return "/questions/" + this.question.id;
    }
  }
};
</script>

<style>
/* List item styling */

article {
  border: #3b3e42 solid 1px;
  border-radius: 0.5rem;
  background-color: #ffcb48;
  overflow: none;
  color: #ffffff;
  text-shadow: 1px 1px #3b3e42;
  padding: 0;
  margin: 0.5rem;
  box-shadow: 0.25rem 0.25rem #999999;
}

article:hover {
  background-color: #f6931d;
}

article a:hover {
  color: #ffffff;
}

/* Styling areas of the list items */

.answer {
  padding: 0.5rem;
  background-color: #3b3e42;
  text-shadow: none;
  height: 8rem;
  overflow: auto;
  font-size: small;
}

.question {
  height: 2rem;
  padding: 0.5rem;
  font-weight: bold;
  min-height: 37px;
}

.questionFooter {
  color: #1e2227;
  padding: 0.25rem;
  display: flex;
  flex-direction: row;
  align-items: center;
}

.visibilityCommands {
  flex-grow: 1;
  align-items: center;
  display: flex;
  flex-direction: row;
  justify-content: flex-start;
}

.gradingCommands {
  flex-grow: 1;
  display: flex;
  flex-direction: row;
  justify-content: flex-end;
  align-items: center;
}

.questionFooter a {
  color: #ffffff;
  margin: 0.25rem;
}

.questionFooter i:hover {
  color: #ffcb48;
}

.markCorrect i:hover {
  color: #8cc63f;
}

.markIncorrect i:hover {
  color: #c63f3f;
}

/* Blur the answer text by default */

article.blur {
  background-color: #00adee;
}

article.blur:hover {
  color: #ffffff;
  background-color: #f6931d;
}

article.blur .answer {
  color: transparent;
  text-shadow: 0 0 5px #ffffff;
}

/* Correct / Incorrect Styling */

article.correct {
  background-color: #8cc63f;
}

article.incorrect {
  background-color: #c63f3f;
}

/* Responsiveness */

@media (min-width: 768px) {
  article {
    width: 17rem;
    flex-grow: 1;
  }
}
</style>