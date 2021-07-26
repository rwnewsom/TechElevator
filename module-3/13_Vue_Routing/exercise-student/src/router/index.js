import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../views/Home.vue';
import MyBooks from '../views/MyBooks.vue';
import NewBook from '../views/NewBook.vue';
import Book from '../views/Book.vue';

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
    path: '/addBook',
    name: 'addbook',
    component: NewBook
  },

  {
    path: '/book/:id',
    name: 'book',
    component: Book
  }

  

];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
