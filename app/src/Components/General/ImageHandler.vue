<template>
  <div 
    id="background__container" 
    class="w-screen min-w-full max-h-[900px] min-h-[915px] flex">
    
    <picture class="flex w-full min-h-screen">
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
        :alt="altText"
        class="object-cover w-full h-auto"
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
    desktopImage: String,
    altText: 
    {
      type: String,
      default: 'Background image'
    }
  });
</script>
