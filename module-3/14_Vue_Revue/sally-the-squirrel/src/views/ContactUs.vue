<template>
  <main>
    <section id="opening">
      <h1>Contact Us</h1>
      <p>So you're wondering how you contact us?</p>
      <p>
        Basically,
        <strong>you don't.</strong>
      </p>
      <p>
        Yep. This web site is essentially a class project to help students learn how to create web applications.
        Don't believe me? Check out our
        <router-link to="about">about</router-link>&nbsp;page.
      </p>
    </section>
    <aside class="featuredImage">
      <img src="../assets/images/Contact.jpg" alt="A squirrel standing and staring attentively" />
      <cite>
        <span>
          Photo by
          <a
            href="https://unsplash.com/@alexxsvch?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >
            Alexey
            Savchenko
          </a> on
          <a
            href="/s/photos/squirrel-letter?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >Unsplash</a>
        </span>
      </cite>
      <blockquote>
        Don't talk to me; I'm practicing social distancing.
        <cite>
          - Sally
          the Squirrel
        </cite>
      </blockquote>
    </aside>
    <section id="contactForm">
      <h2>Want to Try Anyway?</h2>
      <p>Okay, even after hearing all that you still want to try? Fine. Have at it. Here's a contact form. *</p>
      <form v-on:submit.prevent="onFormSubmitted()">
        <div class="form-group">
          <label for="name">Name:</label>
          <input type="text" id="name" autocomplete="name" placeholder="Your Name" />
        </div>

        <div class="form-group">
          <label for="emailaddress">E-Mail Address:</label>
          <input
            type="email"
            id="emailaddress"
            autocomplete="email"
            placeholder="Enter the E-Mail Address you use to log in to your bank"
          />
        </div>

        <div class="form-group">
          <label for="phone">Phone:</label>
          <input
            type="tel"
            id="phone"
            autocomplete="tel"
            placeholder="Enter the phone number associated with your credit card"
          />
        </div>

        <div class="form-group">
          <label for="creditcard">Credit Card:</label>
          <input type="number" id="creditcard" placeholder="Your credit card" />
        </div>

        <div class="form-group">
          <label for="cv3">Credit Card Security Number:</label>
          <input type="number" id="cv3" placeholder="Your 3-digit credit card security code" />
        </div>

        <div class="form-group">
          <label for="password">Bank Password:</label>
          <input
            type="password"
            id="password"
            autocomplete="current-password"
            placeholder="Your bank's password"
          />
        </div>

        <div class="form-group">
          <label for="comments">Comments:</label>
          <textarea id="comments" placeholder="Enter comments here. We won't read them."></textarea>
        </div>

        <p>
          <small>
            * - this form is a joke intended to demonstrate different input types. Do not submit
            confidential
            information to untrusted sources. See
            <a
              href="about.html#noteToVisitors"
            >
              site
              disclaimer
            </a> for more information.
          </small>
        </p>

        <input type="submit" />
      </form>
    </section>
  </main>
</template>

<script>
export default {
  name: "ContactUs",
  data: () => {
    return {
      locations: [
        "42 Wallaby Way, Sydney, Australia",
        "555 Fake Address Way, Westerville, Ohio 43081",
        "The Batcave, under Matt's house"
      ],
      modules: ["C#", "SQL", "ASP .NET MVC", "HTML / CSS / JS / Vue.js"]
    };
  },
  methods: {
    onFormSubmitted: () => {
      alert("Don't seriously send your confidential information, you fool!");
    }
  }
};
</script>

<style>
@import "../assets/styles/forms.css";
</style>