<template>
  <div 
    id="background__container" 
    class="flex justify-center items-center w-screen h-screen min-h-screen overflow-hidden">
  
  <picture 
    id="background__picture" 
    class="flex w-screen h-screen min-h-screen overflow-hidden">

      <!-- Mobile Image -->
      <source 
        media="(max-width: 450px)" 
        :srcset=mobileImage
        alt="Background Picture Mobile"
      >

      <!-- Tablet Image -->
      <source 
        media="(max-width: 610px)" 
        :srcset=tabletImage
        alt="Background Picture Tablet"
      >

      <!-- Desktop Image -->
      <source 
        media="(min-width: 611px)" 
        :srcset=desktopImage
        alt="Background Picture Desktop"
      >

      <!-- Default image -->
      <img 
        :src=mobileImage 
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
  