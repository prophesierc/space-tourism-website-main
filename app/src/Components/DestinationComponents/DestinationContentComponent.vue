<template>
  <div 
    id="destination__content__container" 
    class="flex flex-col absolute w-screen items-center mt-[6em] h-[25em]"
    style="font-family: var(--ff-barlow-condensed);"
    aria-labelledby="destination-header"
  >

    <Header 
      :pageNumber="destinationPage" 
      :intro="destinationIntro" 
      id="destination-header"
    />
    <DestinationSelector 
      :getData="getData" 
      :index="value" 
      aria-label="Destination selector"
    />
    <DestinationNavigationDrawer 
      v-model="value" 
      aria-label="Destination navigation drawer"
    />
    
  </div>
</template>

<script setup>
  import { ref, onMounted } from 'vue';
  import { defineAsyncComponent } from 'vue';
  import { FetchAPI } from '@/Composables/FetchAPI';

  const DestinationSelector = defineAsyncComponent(() => 
    import('@/Components/DestinationComponents/DestinationProps/DestinationSelector.vue'));

  const DestinationNavigationDrawer = defineAsyncComponent(() => 
    import('@/Components/DestinationComponents/DestinationNavigationDrawer.vue'));

  const Header = defineAsyncComponent(() => 
    import('@/Components/General/Header.vue'));

  const destinationPage = "01"; 
  const destinationIntro = "PICK YOUR DESTINATION"; 
  const value = ref(0); 
  const { getData, getRequest } = FetchAPI(); 

  onMounted(async () => 
  {
    const data = await getRequest('/destinations');
    getData.value = data; 
  });
</script>

