import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../views/Home.vue';
import MyBooks from '../views/MyBooks.vue';
import NewBook from '../views/NewBook.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name:'home',
    component: Home
  },

  {
    path: '/myBooks',
    name: 'mybooks',
    component: MyBooks
  },

  {
    path: '/addbook',
    name: 'addbook',
    component: NewBook
  }

  

];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
