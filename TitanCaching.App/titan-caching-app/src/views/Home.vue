<template>
  <div class="home">
    <div class="row">
      <div class="col-1">
      </div>
      <div class="col-5 z-index-negative-1" style="height:100vh;">
        <img src="../assets/Images/r.png" class="image-position" />
      </div>
      <div class="col-2">

      </div>
      <div class="col-4" style="padding-top: 6%;">
        <div class="container-welcome border-bottom-purple">
          <h2 class="oswald-font">Welcome to Titan Caching</h2>
          <h3 class="oswald-font font-size-small position-sub-title">Easy Access Management</h3>
        </div>
      </div>
    </div>
  </div>
</template>

<script>

export default {
  name: 'Home',
  components: {
  }
}
</script>

<style>
  @import url('https://fonts.googleapis.com/css2?family=Oswald:wght@300&display=swap');

  .oswald-font {
    font-family: 'Oswald', sans-serif;
  }

  .position-sub-title {
    padding-left: 83px;
    margin-top: -13px;
  }

  .font-size-small {
    font-size: 1.4rem;
  }

  .image-position {
    padding-top: 20px;
  }

  .z-index-negative-1{
      z-index: -1;
  }

  .container-welcome {
    width: 302px;
  }

  .border-bottom-purple {
    border-bottom: 7px solid #9A5B93;
  }
</style>
