<template>
  <div>
    <div class="form-group">
      <label for="question">Question:</label>
      <input
        type="text"
        id="question"
        v-model="question.question"
        placeholder="Enter a question name"
        required
      />
    </div>

    <div class="form-group">
      <label for="answer">Answer:</label>
      <textarea placeholder="Question answer goes here..." v-model="question.answer" id="answer"></textarea>
    </div>

    <div class="form-group">
      <label>Difficulty Level:</label>
      <div class="form-check">
        <input
          type="radio"
          name="contact"
          value="1"
          id="answerEasy"
          v-model="question.difficulty"
          checked
        />
        <label for="answerEasy">Easy</label>
      </div>
      <div class="form-check">
        <input
          type="radio"
          name="contact"
          value="2"
          id="answerMedium"
          v-model="question.difficulty"
        />
        <label for="answerMedium">Medium</label>
      </div>
      <div class="form-check">
        <input type="radio" name="contact" value="3" id="answerHard" v-model="question.difficulty" />
        <label for="answerHard">Hard</label>
      </div>
    </div>

    <div class="form-group">
      <label for="learnmore">Additional Details URL:</label>
      <input
        type="url"
        id="learnmore"
        placeholder="Learn more URL goes here"
        v-model="question.learnMoreUrl"
      />
    </div>

    <div class="form-group">
      <!-- Category Labels -->
      <label>Categories:</label>
      <div class="form-check-grid">
        <div class="form-check" v-for="cat of categories" v-bind:key="cat.tag">
          <input type="checkbox" v-bind:id="getCheckboxId(cat)" v-bind:name="cat.tag" />
          <label v-bind:for="getCheckboxId(cat)">{{cat.name}}</label>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "QuestionForm",
  props: {
    question: {
      type: Object,
      default: function() {
        return {
          question: "",
          answer: "",
          difficulty: 1,
          learnMoreUrl: "",
          categories: [],
          isCorrect: undefined,
          id: -1,
          isAnswerVisible: false
        };
      }
    }
  },
  data: () => {
    return {
      categories: [
        { tag: "dotnet", name: ".NET" },
        { tag: "csharp", name: "C#" },
        { tag: "oop", name: "OOP" },
        { tag: "aspnet", name: "ASP .NET" },
        { tag: "js", name: "JavaScript" },
        { tag: "vuejs", name: "Vue.js" },
        { tag: "java", name: "Java (ew)" },
        { tag: "sql", name: "SQL" },
        { tag: "html", name: "HTML" },
        { tag: "css", name: "CSS" },
        { tag: "testing", name: "Testing" },
        { tag: "git", name: "git" }
      ]
    };
  },
  methods: {
    getCheckboxId: cat => {
      return "cat_" + cat.tag;
    }
  }
};
</script>

<style>
@import "../assets/styles/forms.css";
</style>