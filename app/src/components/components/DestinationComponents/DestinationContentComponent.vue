<template>
  <div 
    id="destination__content__container" 
    class="flex flex-col absolute w-full items-center mt-[6em] h-[25em]" 
    style="font-family: var(--ff-barlow-condensed);"
  >
    <div id="content__container" class="flex flex-col items-center mb-auto w-auto">
      <span class="flex text-[16px] tracking-widest ">
        <span class="font-bold pr-5 text-[#53555f]"> 01 </span>
        <h1 class="text-white"> PICK YOUR DESTINATION </h1>
      </span>

        <DestinationSelector :index="value" />
    </div>

    <DestinationNavigationDrawer v-model="value" />
  </div>
</template>

<script setup>
import { ref } from 'vue';
import DestinationSelector from '@/Components/props/DestinationProps/DestinationSelector.vue';
import DestinationNavigationDrawer from '@/Components/components/DestinationComponents/DestinationNavigationDrawer.vue';

const value = ref(0); // Default to Moon
</script>
