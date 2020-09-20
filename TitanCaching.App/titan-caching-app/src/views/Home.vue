<template>
  <div class="home">
    <div class="row">
      <div class="col-1">
      </div>
      <div class="col-5 landing-page-image z-index-negative-1 animate__animated animate__bounceIn animate__delay-2s" style="height:100vh;">
      </div>
      <div class="col-5">
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

  .landing-page-image {
    background-image: url(../assets/Images/r.png);
    background-repeat: no-repeat;
  }

  .z-index-negative-1{
      z-index: -1;
  }
</style>
