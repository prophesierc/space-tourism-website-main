<template>
  <div 
    id="background__container" 
    class="flex justify-center items-center w-screen h-screen min-h-screen overflow-hidden">
  
  
  <picture 
    id="background__picture" 
    class="flex w-screen h-screen min-h-screen overflow-hidden">

      <!-- Mobile Image -->
      <source 
        media="(max-width: 449px)" 
        v-lazy="mobileImage"
        alt="Background Picture Mobile"
      >

      <!-- Tablet Image -->
      <source 
        media="(max-width: 609px)" 
        v-lazy="tabletImage"
        alt="Background Picture Tablet"
      >

      <!-- Desktop Image -->
      <source 
        media="(min-width: 610px)" 
        v-lazy="desktopImage"
        alt="Background Picture Desktop"
      >

      <!-- Default image -->
      <img 
        v-lazy="tabletImage"
        alt="Background Picture" 
        class="object-cover w-screen h-screen"
      >

    </picture>
  </div>
</template>
  
<script setup>
  const props = defineProps(
  {
    mobileImage: String,
    tabletImage: String,
    desktopImage: String
  });

  defineOptions({ name: 'ImageHandler'});
</script>
  