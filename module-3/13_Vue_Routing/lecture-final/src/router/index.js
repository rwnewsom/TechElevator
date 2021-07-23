import Vue from 'vue'
import VueRouter from 'vue-router'
import ProductReview from '../views/ProductReviewView.vue'
import About from '../views/AboutView.vue'
import TableView from '../views/TableView.vue'
import AddReview from '../views/AddReviewView.vue'
import ReviewDetails from '../views/ReviewDetailsView.vue'
import NotFound from '../views/NotFoundView.vue'

Vue.use(VueRouter)

const routes = [

  {
    // The URL path to look at for this page
    path: '/', // Home page
    
    // A unique identifier for this route
    name: 'list',

    // A component (view) to display in router-view when this route is active
    component: ProductReview
  },

  {
    path: '/about-this-app',
    name: 'about',
    component: About
  },

  {
    path: '/main',
    name: 'table',
    component: TableView
  },

  {
    path: '/add-review',
    name: 'new',
    component: AddReview
  },

  {
    path: '/reviews/:id', // ASP .NET way would be "/reviews/{id}"
    name: 'review-details',
    component: ReviewDetails
  },

  {
    path: '*', // Wildcard - didn't match anything else
    name: 'not-found',
    component: NotFound
  }

]

/*
History Mode:
localhost:8080/about
localhost:8080/add-review

Hash Mode - for when your server doesn't support History Mode:
localhost:8080/#about
localhost:8080/#add-review
*/

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
