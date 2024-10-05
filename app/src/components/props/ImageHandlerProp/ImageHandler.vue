<template>
  <div 
    id="background__container" 
    class="w-screen h-screen min-h-screen overflow-hidden">
    
    <picture class="w-full h-full">
      <!-- Mobile Image -->
      <source
        media="(max-width: 449px)"
        :srcset="mobileImage"
      />

      <!-- Tablet Image -->
      <source
        media="(max-width: 609px)"
        :srcset="tabletImage"
      />

      <!-- Desktop Image -->
      <source
        media="(min-width: 610px)"
        :srcset="desktopImage"
      />

      <!-- Fallback Image -->
      <img
        :src="mobileImage"
        alt="Background Image"
        class="object-cover w-full h-full"
      />
    </picture>

  </div>
</template>

<script setup>
  defineOptions({ name: 'ImageHandler' });

  const props = defineProps(
  {
    mobileImage: String,
    tabletImage: String,
    desktopImage: String
  });
</script>
