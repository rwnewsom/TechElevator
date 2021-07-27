import Vue from "vue";
import VueRouter from "vue-router";
import Home from "../views/Home.vue";

Vue.use(VueRouter);

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home,
  },
  { path: "/home", redirect: "/" },
  {
    path: "/aboutus",
    name: "About",
    component: () => import("../views/AboutUs.vue"),
  },
  { path: "/about", redirect: "/aboutus" },
  {
    path: "/questions/:id",
    name: "QuestionDetails",
    props: true,
    component: () => import("../views/QuestionDetails.vue"),
  },
  {
    path: "/questions",
    name: "Questions",
    component: () => import("../views/Questions.vue"),
  },
  {
    path: "/ask",
    name: "Ask",
    component: () => import("../views/AskQuestion.vue"),
  },
  {
    path: "/services",
    name: "Services",
    component: () => import("../views/Services.vue"),
  },
  {
    path: "/contact",
    name: "Contact",
    component: () => import("../views/ContactUs.vue"),
  },
  {
    path: "*",
    name: "NotFound",
    component: () => import("../views/NotFound.vue"),
  },
];

export const router = new VueRouter({
  mode: "history",
  linkExactActiveClass: "active",
  routes,
});

export default router;
