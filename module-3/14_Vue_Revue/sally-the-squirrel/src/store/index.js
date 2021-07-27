import Vue from "vue";
import Vuex from "vuex";
import restService from "../services/RestService.js";
import { router } from "../router/index";

Vue.use(Vuex);

function addChangeDetectionFields(question) {
  question.isAnswerVisible = false;
  question.isCorrect = undefined;
  return question;
}

export default new Vuex.Store({
  state: {
    questions: [],
    currentView: "Home",
    isBusy: true
  },
  getters: {
    questionList: (state) => state.questions,
    findQuestion: (state) =>
      function (id) {
        return state.questions.find((q) => q.id == id); // Using == to support strings from URLs
      },
      isBusy: (state) => state.isBusy
  },
  actions: {
    getQuestions(context) {
      context.commit("BUSY");
      restService.list()
        .then(response => {
          const questions = response.data.map(addChangeDetectionFields);
          context.commit("SET_QUESTIONS", questions);
        })
        .catch(err => {
          console.error('Could not get questions', err);
          alert('There was a problem loading question data. Try again later.');
        })
        .finally(() => {
          context.commit("NOT_BUSY");
        });
    },
    refreshQuestion(context, payload) {
      context.commit("BUSY");
      restService.get(payload)
        .then(response => {
          const question = addChangeDetectionFields(response.data);
          context.commit("QUESTION_UPDATED", question);
        })
        .catch(err => {
          console.error('Could not load question ' + payload, err);
          alert('There was a problem fetching your question. Try again later.');
        })
        .finally(() => {
          context.commit("NOT_BUSY");
        });
    },
    addQuestion(context, payload) {
      context.commit("BUSY");
      restService.create(payload)
        .then(response => {
          const newQuestion = addChangeDetectionFields(response.data);
          context.commit("ADD_QUESTION", newQuestion);
          router.push("/questions/" + newQuestion.id);    
        })
        .catch(err => {
          console.error('Could not add question', err);
          alert('There was a problem adding your question. Try again later.');
        })
        .finally(() => {
          context.commit("NOT_BUSY");
        });
    },
    saveQuestion(context, payload) {
      context.commit("BUSY");
      restService.update(payload)
        .then(response => {
          const question = addChangeDetectionFields(response.data);
          context.commit("QUESTION_UPDATED", question);
          router.push("/questions");
        })
        .catch(err => {
          console.error('Could not save question ' + payload.id, err);
          alert('There was a problem saving your question. Try again later.');
        })
        .finally(() => {
          context.commit("NOT_BUSY");
        });
    },
    deleteQuestion(context, payload) {
      context.commit("BUSY");
      restService.delete(payload)
        .then(() => {
          context.commit("QUESTION_DELETED", payload.id);
          router.push("/questions");
        })
        .catch(err => {
          console.error('Could not delete question ' + payload.id, err);
          alert('There was a problem deleting your question. Try again later.');
        })
        .finally(() => {
          context.commit("NOT_BUSY");
        });
    },    
    showAnswer(context, payload) {
      context.commit("SHOW_ANSWER", payload.id);
    },
    showAllAnswers(context) {
      context.commit("SHOW_ALL_ANSWERS");
    },
    hideAnswer(context, payload) {
      context.commit("HIDE_ANSWER", payload.id);
    },
    hideAllAnswers(context) {
      context.commit("HIDE_ALL_ANSWERS");
    },
    markCorrect(context, payload) {
      context.commit("MARK_CORRECT", payload.id);
    },
    markIncorrect(context, payload) {
      context.commit("MARK_INCORRECT", payload.id);
    },
    toggleCorrect(context, payload) {
      const question = context.state.questions.find((q) => q.id == payload.id);
      if (question.isCorrect == true) {
        context.commit("MARK_INCORRECT", question.id);
      } else {
        context.commit("MARK_CORRECT", question.id);
      }
    },
  },
  mutations: {
    NOT_BUSY(state) {
      state.isBusy = false;
    },
    BUSY(state) {
      state.isBusy = true;
    },
    SET_QUESTIONS(state, payload) {
      state.questions = payload;
      state.isLoading = false;
    },
    ADD_QUESTION(state, payload) {
      state.questions.push(payload);
    },
    QUESTION_UPDATED(state, payload) {
      const index = state.questions.findIndex((q) => q.id === payload.id);
      state.questions.splice(index, 1, payload);
    },
    QUESTION_DELETED(state, payload) {
      const index = state.questions.findIndex((q) => q.id === payload);
      state.questions.splice(index, 1);
    },
    SHOW_ANSWER(state, payload) {
      const question = state.questions.find((q) => q.id == payload);
      question.isAnswerVisible = true;
    },
    SHOW_ALL_ANSWERS(state) {
      state.questions.forEach((q) => (q.isAnswerVisible = true));
    },
    HIDE_ANSWER(state, payload) {
      const question = state.questions.find((q) => q.id == payload);
      question.isAnswerVisible = false;
      question.isCorrect = undefined; // If it's hidden, forget our answer to it
    },
    HIDE_ALL_ANSWERS(state) {
      state.questions
        .filter((q) => q.isCorrect == undefined)
        .forEach((q) => (q.isAnswerVisible = false));
    },
    MARK_CORRECT(state, payload) {
      const question = state.questions.find((q) => q.id == payload);
      question.isCorrect = true;
      question.isAnswerVisible = true;
    },
    MARK_INCORRECT(state, payload) {
      const question = state.questions.find((q) => q.id == payload);
      question.isCorrect = false;
      question.isAnswerVisible = true;
    },
  },
});
