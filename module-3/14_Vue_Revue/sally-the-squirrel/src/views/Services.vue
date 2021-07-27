<template>
  <main>
    <section id="opening">
      <h1>Services</h1>
      <p>
        Sally's isn't
        <em>just</em> about interview questions. We also offer a wide variety of professional
        services to help augment our income. Er, I mean, provide value to you, the customer!
      </p>

      <h2>Available Services</h2>
      <p>Take a look at our valuable services:</p>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Price</th>
            <th>Min Hours</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="service of services" v-bind:key="service.id">
            <th>{{service.code}}</th>
            <td v-html="service.name"></td>
            <td>${{service.price}} / hour</td>
            <td>{{service.minHours}}</td>
          </tr>
        </tbody>
      </table>
      <p>
        <small>
          * - Sally the Squirrel, Tech Elevator, and its staff do not condone
          violent, criminal, or unethical behavior of any sort. See
          <a href="about.html#noteToVisitors">
            site
            disclaimer
          </a> for more.
        </small>
      </p>
      <p>
        <small>
          ** - WTYPRT service should not be construed as meaning that we will actually
          <em>fix</em>
          your problem or that the problem we point out is actually real.
        </small>
      </p>
    </section>

    <aside class="featuredImage">
      <img src="../assets/images/Services.jpg" alt="A squirrel taking shelter inside a feeder" />
      <cite>
        <span>
          Photo by
          <a
            href="https://unsplash.com/@jhonkasalo?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >
            Joakim
            Honkasalo
          </a> on
          <a
            href="/s/photos/squirrel?utm_source=unsplash&amp;utm_medium=referral&amp;utm_content=creditCopyText"
          >Unsplash</a>
        </span>
      </cite>
      <blockquote>
        A certain someone told me you had a problem you needed help with discretely. I can help.
        <cite>
          - Sally
          the Squirrel
        </cite>
      </blockquote>
    </aside>

    <section id="closing">
      <h2>Request Services</h2>
      <p>
        If you see any service you'd like to pay for or have additional questions, feel free to
        <router-link to="contact">contact us</router-link>.
      </p>
    </section>
  </main>
</template>

<script>
export default {
  name: "Services",
  data: () => {
    return {
      services: [
        {
          code: "COMPL",
          name: "We get your code to compile. By force, if necessary. *",
          price: 99,
          minHours: 1
        },
        {
          code: "HR",
          name:
            "We 'handle' the HR interview for you, so you can keep prepping for the technical. *",
          price: 35,
          minHours: 3
        },
        {
          code: "SOCIAL",
          name: "We promote you on social media.",
          price: 18,
          minHours: 2
        },
        {
          code: "WTYPRT",
          name:
            "We take a glance at your code exclaim <q>Well, there's your problem right there!</q>. **",
          price: 42,
          minHours: 1
        }
      ]
    };
  },
  methods: {}
};
</script>

<style>
/* Table Styling */
table {
  font-size: medium;
  color: #ffffff;
  text-shadow: #3b3e42 1px 1px;
  border: #8cc63f solid 0.15rem;
  border-collapse: collapse;
}

thead th {
  text-align: left;
  text-transform: capitalize;
  background-color: #00adee;
}

tbody th {
  text-align: left;
  padding-right: 0.5rem;
}

tbody tr:nth-child(odd) {
  background-color: #999999;
}
tbody tr:nth-child(even) {
  background-color: #3b3e42;
}
</style>