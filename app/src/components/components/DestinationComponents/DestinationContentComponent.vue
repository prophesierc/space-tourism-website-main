<template>
  <div 
    id="destination__content__container" 
    class="flex flex-col absolute w-screen h-screen justify-center mt-[6rem]" 
    style="font-family: var(--ff-barlow-condensed);"
  >
    <div 
      id="content__container" 
      class="flex flex-col items-center mb-auto w-auto h-[38rem]">
      <span 
      class="flex text-[16px] tracking-widest text-[#d0d6f9]">
        <span 
        class="font-bold pr-5 text-[#53555f]"> 01 </span>
        <span> PICK YOUR DESTINATION </span>
      </span>    
      
      <DestinationImg :index="0" />
    </div>
  </div>
</template>
<script setup>
  defineOptions({ name: 'DestinationContentComponent' })
  import DestinationImg from '@/Components/props/DestinationProps/DestinationImg.vue';
</script>