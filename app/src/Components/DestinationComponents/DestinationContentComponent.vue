<template>
  <div 
    id="destination__content__container" 
    class="flex flex-col absolute w-full items-center mt-[6em] h-[25em]" 
    style="font-family: var(--ff-barlow-condensed);">

    <Header :pageNumber="destinationPage" :intro="destinationIntro" />
    <DestinationSelector :getData="getData" :index="value" />
    <DestinationNavigationDrawer v-model="value" />
    
  </div>
</template>

<script setup>
  import { ref, onMounted } from 'vue';
  import { defineAsyncComponent } from 'vue';
  import { FetchAPI } from '@/Composables/FetchAPI';

  // Define components
  const DestinationSelector = defineAsyncComponent(() => 
    import('@/Components/DestinationComponents/DestinationProps/DestinationSelector.vue'));

  const DestinationNavigationDrawer = defineAsyncComponent(() => 
    import('@/Components/DestinationComponents/DestinationNavigationDrawer.vue'));

  const Header = defineAsyncComponent(() => 
    import('@/Components/General/Header.vue'));

  // Component data
  const destinationPage = "01"; 
  const destinationIntro = "PICK YOUR DESTINATION"; 
  const value = ref(0); // Default to Moon

  const { getData, getRequest } = FetchAPI(); 

  onMounted(async () => 
  {
    const data = await getRequest('/destinations');
    getData.value = data; 
  });
</script>
