<template>
  <main>
    <aside class="featuredImage">
      <img
        src="../assets/images/SquirrelPhone.jpg"
        alt="Sally the Squirrel holding a silly cell phone"
      />
      <cite>
        Photo by
        <a
          href="https://www.redbubble.com/i/photographic-print/Squirrelisimo-Social-Media-by-Junkyardmax/24049754.6Q0TX"
        >Junkyardmax</a>
      </cite>
      <blockquote>
        I'm known for my fantastic cigar parties, but I also love helping people like you find that first
        programming job.
        <cite>- Sally the Squirrel</cite>
      </blockquote>
    </aside>
    <section id="opening">
      <h1>Welcome</h1>
      <div>
        <p>
          Welcome to
          <i>Sally the Squirrel's One-Stop Interview Question Shop!</i>
        </p>
        <p>
          This site was created as a way of teaching a bunch of future programmers from
          <a
            href="https://www.TechElevator.com?ref=SallyTheSquirrel"
          >Tech Elevator</a>
          how to develop applications in HTML, CSS, JavaScript, and Vue.js. These folks are pretty awesome,
          and
          the subject matter of this site also gives them a way of polishing up on technical interview
          questions
          related to C#, SQL, and web technologies.
        </p>
        <p>
          Check the header and footer for all links, but I strongly recommend you check out the
          <router-link to="questions">questions page</router-link>.
        </p>
      </div>
    </section>
  </main>
</template>

<script>
export default {
  name: "Home",
  props: {}
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
