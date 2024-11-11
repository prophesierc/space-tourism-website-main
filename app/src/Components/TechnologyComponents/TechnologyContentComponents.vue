<template>
  <div 
    id="destination__content__container" 
    class="flex flex-col absolute w-full items-center mt-[6em] h-[25em]" 
    style="font-family: var(--ff-barlow-condensed);">

    <Header :pageNumber="techPage" :intro="techIntro" />
    <TechnologyCarousel />
  </div>
</template>
  
<script setup>
  defineOptions({ name: 'TechnologyContentComponents' })
  import { defineAsyncComponent } from 'vue';

  const Header = defineAsyncComponent(() => 
    import('@/Components/General/Header.vue'));

  const TechnologyCarousel = defineAsyncComponent(() => 
    import('@/Components/TechnologyComponents/TechnologyCarousel.vue'));

  const techPage = "03"; 
  const techIntro = "SPACE LAUNCH 101";
</script>