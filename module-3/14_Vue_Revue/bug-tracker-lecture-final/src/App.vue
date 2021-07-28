<template>
  <div id="app">
    <!-- Header at top (Branding) -->
    <header>
      <strong>Elevator Bugs</strong>
    </header>

    <!-- Sidebar (Navigation) -->
    <aside>
      <nav id="nav" class="mt-3">
        <ul>
          <li><router-link v-bind:to="{name:'Home'}">Home</router-link></li>
          <li><router-link v-bind:to="{name:'BugsList'}">Bugs</router-link></li>
          <li><router-link v-bind:to="{name:'About'}">About</router-link></li>
        </ul>
      </nav>
    </aside>

    <!-- Main Content (Active Page) -->
    <main>
      <router-view/>
    </main>
  </div>
</template>

<style lang="scss">

$accentDark: #3D5A80;
$accentLight: #98C1D9;
$background: #E0FBFC;
$danger: #EE6C4D;
$dark: #293241;
$light: white;

html {
  background-color: $background;
  color: $dark;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: $dark;
  min-height: 800px;

  display: grid;
  grid-template-areas: "brand brand"
    "sidebar page";
  grid-template-columns: 1fr 5fr;
  grid-template-rows: auto 1fr;
}

#app > header {
  grid-area: brand;
  background-color: $accentDark;
  color: $light;
  font-size: 200%;
  padding: 0.5rem 1rem;
}

#app > aside {
  grid-area: sidebar;
  background-color: $dark;
  color: $light;
}

#app > main {
  grid-area: page;
  padding: 1rem;
}

#nav {
  a {
    text-align: left;
    font-weight: bold;
    color: $accentLight;

    &.router-link-exact-active {
      color: $danger;
    }
  }

  a:hover {
    color: $light;
  }

  li {
    text-align: left;
    list-style-type: none;
    margin-bottom: 0.5rem;
  }
}
</style>
