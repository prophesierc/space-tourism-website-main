<template>
  <header id="header__container" class="flex justify-center align-center w-screen min-h-screen z-0">
    <picture id="header__picture" class="flex w-screen h-screen">
      <!-- Mobile Image -->
      <source media="(max-width: 450px)" srcset="@/assets/home/background-home-mobile.jpg" alt="Header Picture Mobile">
      <!-- Tablet Image -->
      <source media="(max-width: 610px)" srcset="@/assets/home/background-home-tablet.jpg" alt="Header Picture Tablet">
      <!-- Desktop Image -->
      <source media="(min-width: 611px)" srcset="@/assets/home/background-home-desktop.jpg" alt="Header Picture Desktop">
      <!-- Default image -->
      <img src="@/assets/home/background-home-mobile.jpg" alt="Header Picture" class="object-cover w-screen h-screen">
    </picture>
  </header>
</template>
  
<script setup>
// Passes explicitly the component name as object inside defineOptions function
defineOptions({ name: 'ImageHandler'});
</script>
  