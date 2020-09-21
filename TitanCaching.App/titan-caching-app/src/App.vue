<template>
  <div id="app">
    <div id="nav" class="z-index-10">
      <div class="row w-100 h-100">
        <div class="col-lg-3 col-md-2 col-sm-2">
        </div>
        <div class="col-lg-6 col-md-6 col-sm-6" style=" padding-top: 43px;">
          <router-link class="white-text oswald-font font-size router-link" to="/">Caching Statistics</router-link>
          <span class="circle"></span>
          <router-link class="white-text oswald-font font-size router-link" to="/about">Customized Filtering</router-link>
          <span class="circle"></span>
          <router-link class="white-text oswald-font font-size router-link" to="/about">All Keys</router-link>
          <span class="circle"></span>
          <router-link class="white-text oswald-font font-size router-link" to="/about">Expiry Date</router-link>
        </div>
        <div class="col-lg-3 col-md-3 col-sm-4 p-0 background-logo">
        </div>
      </div>
    </div>
    <Footer></Footer>
    <router-view />
  </div>
</template>

<script>
  import Footer from './components/Footer.vue'
  export default {
    name: 'App',
    components: {
      Footer
    }
  }
</script>

<style>
  @import url('https://fonts.googleapis.com/css2?family=Oswald:wght@300&display=swap');

  #app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
  }

  #nav {
    height: 121px;
    background: #3E3E3E;
    border-bottom: 3px solid #1a8bc5;
    box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  }

  .router-link:hover {
    color: #efefef;
  }
  .font-size {
    font-size: 0.95rem;
  }

  .border-logo {
    border-top: solid 1px;
    border-bottom: solid 1px;
    padding-top: 12px;
    padding-bottom: 12px;
  }

  .white-text {
    color: #efefef;
    text-decoration: none !important;
  }

  .oswald-font {
    font-family: 'Oswald', sans-serif;
  }

  .logo-sizing {
    height: 125px;
    float: right;
  }

  .circle {
    height: 8px;
    width: 8px;
    background-color: #1A8BC5;
    border-radius: 50%;
    margin-right: 9px;
    display: inline-block;
    margin-left: 9px;
    margin-top: 8px;
  }

  body {
    margin: 0px !important;
    overflow: hidden;
  }

  .background-logo {
    background-image: url(assets/Images/logotext.png);
    background-repeat: no-repeat;
  }

  .z-index-10{
    z-index: 10;
  }
</style>
