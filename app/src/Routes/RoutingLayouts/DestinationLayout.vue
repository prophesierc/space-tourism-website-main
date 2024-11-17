<template>
  <v-app>
    <NavBar :activeIndex="1" />
      <DestinationContentComponent />
      <ImageHandler 
      :mobileImage="BackgroundDestinationMobile"
      :tabletImage="BackgroundDestinationTablet"
      :desktopImage="BackgroundDestinationDesktop"
      />
  </v-app>
</template>
  
<script setup>
  defineOptions({ name: 'DestinationLayout' });
  import { defineAsyncComponent } from 'vue';

  const DestinationContentComponent = defineAsyncComponent(() => 
    import('@/Components/DestinationComponents/DestinationContentComponent.vue'));

  const NavBar = defineAsyncComponent(() => 
    import('@/Components/General/NavBar.vue'));

  const ImageHandler = defineAsyncComponent(() => 
    import('@/Components/General/ImageHandler.vue')); 
  
  // ImageHandler prop images
  import BackgroundDestinationMobile from '@/assets/destination/background-destination-mobile.jpg';
  import BackgroundDestinationTablet from '@/assets/destination/background-destination-tablet.jpg';
  import BackgroundDestinationDesktop from '@/assets/destination/background-destination-desktop.jpg';
</script>
  