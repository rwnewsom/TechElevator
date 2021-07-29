import Vue from "vue";
import Router from "vue-router";
import Home from "../views/Home.vue";
import Login from "../views/Login.vue";
import Logout from "../views/Logout.vue";
import Register from "../views/Register.vue";
import store from "../store/index";
import BugList from '../views/BugsList.vue'
import BugDetails from '../views/BugDetails.vue'
import AddBug from '../views/AddBug.vue'
import NotFound from '../views/NotFound.vue'
import BugEdit from '../views/EditBug.vue'

Vue.use(Router);

/**
 * The Vue Router is used to "direct" the browser to render a specific view component
 * inside of App.vue depending on the URL.
 *
 * It also is used to detect whether or not a route requires the user to have first authenticated.
 * If the user has not yet authenticated (and needs to) they are redirected to /login
 * If they have (or don't need to) they're allowed to go about their way.
 */

const router = new Router({
  mode: "history",
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      path: '/bugs',
      name: 'BugsList',
      component: BugList
    },
    {
      path: '/bugs/new',
      name: 'NewBug',
      component: AddBug,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: '/bugs/:id/edit',
      name: 'BugEdit',
      component: BugEdit,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: '/bugs/:id',
      name: 'BugDetails',
      component: BugDetails,
    },
    {
      path: '/about',
      name: 'About',
      component: () => import('../views/About.vue')
    },
    {
      path: "/login",
      name: "login",
      component: Login,
      meta: {
        requiresAuth: false,
        likesBurritos: true,
      },
    },
    {
      path: "/logout",
      name: "logout",
      component: Logout,
      meta: {
        requiresAuth: false,
      },
    },
    {
      path: "/register",
      name: "register",
      component: Register,
      meta: {
        requiresAuth: false,
      },
    },
    {
      path: '*',
      name: 'NotFound',
      component: NotFound
    },    
  ],
});

router.beforeEach((to, from, next) => {
  // Determine if the route requires Authentication
  const requiresAuth = to.matched.some((x) => x.meta.requiresAuth);

  // If it does and they are not logged in, send the user to "/login"
  if (requiresAuth && store.state.token === "") {
    next("/login");
  } else {
    // Else let them go to their next destination
    next();
  }
});

export default router;
