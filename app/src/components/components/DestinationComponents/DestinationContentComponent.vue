<template>
  <div 
    id="destination__content__container" 
    class="flex flex-col absolute w-full items-center mt-[6em] h-[25em]" 
    style="font-family: var(--ff-barlow-condensed);"
  >
  <Header :pageNumber="crewPage" :intro="crewintro" />
  <DestinationSelector :index="value" />
  <DestinationNavigationDrawer v-model="value" />
  </div>
</template>

<script setup>
  import { ref } from 'vue';
  import DestinationSelector from '@/Components/props/DestinationProps/DestinationSelector.vue';
  import DestinationNavigationDrawer from '@/Components/components/DestinationComponents/DestinationNavigationDrawer.vue';
  import Header from '@/Components/props/GeneralProps/Header/Header.vue'

  const crewPage = "01"; // Default to Moon
  const crewintro = "PICK YOUR DESTINATION"; // Default to Moon
  const value = ref(0); // Default to Moon
</script>
