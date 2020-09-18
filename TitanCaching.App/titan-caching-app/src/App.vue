<template>
  <div id="app">
    <div id="nav">
      <div class="row w-100 h-100">
        <div class="col-10">
            <div class="row w-100" style="height: 62px;">
            </div>
            <div class="row">
              <div class="col-4">
              </div>
              <div class="col-6">
                <router-link class="white-text oswald-font font-size" to="/">Caching Statistics</router-link>
                <span class="circle"></span>
                <router-link class="white-text oswald-font font-size" to="/about">Customized Filtering</router-link>
                <span class="circle"></span>
                <router-link class="white-text oswald-font font-size" to="/about">All Keys</router-link>
                <span class="circle"></span>
                <router-link class="white-text oswald-font font-size" to="/about">Expiry Date</router-link>
              </div>
            </div>
        </div>
        <div class="col-2 p-0">
          <div class="row w-100 m-0">
            <div class="col-2">
            </div>
            <div class="col-4">
              <div class="row w-100" style="height: 45px;" >
              </div>
              <div class="row">
                <div class="col-12">
                  <span class="white-text oswald-font border-logo">Titan Caching</span>
                </div>
              </div>
            </div>
            <div class="col-5">
              <img class="logo-sizing" src="./assets/Images/logo.png">
            </div>
          </div>
        </div>
      </div>
    </div>
    <router-view/>
  </div>
</template>

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
</style>
