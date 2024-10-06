<template>
    <div 
      id="destination__content__container" 
      class="flex flex-col absolute w-full items-center mt-[6em] h-[25em]" 
      style="font-family: var(--ff-barlow-condensed);"
    >
      <div 
        id="content__container" 
        class="flex flex-col items-center mb-auto w-auto">
        <span 
        class="flex text-[16px] tracking-widest text-[#d0d6f9]">
          <span 
          class="font-bold pr-5 text-[#53555f]"> 01 </span>
          <span> PICK YOUR DESTINATION </span>
        </span>    
        
        <DestinationImg :index="1" />
      </div>
  
      <DestinationNavigationDrawer />
    </div>
  </template>
  
  <script setup>
    defineOptions({ name: 'Mars' })
    import DestinationImg from '@/Components/props/DestinationProps/DestinationImg.vue';
    import DestinationNavigationDrawer from '@/Components/components/DestinationComponents/DestinationNavigationDrawer.vue';
  
  </script>