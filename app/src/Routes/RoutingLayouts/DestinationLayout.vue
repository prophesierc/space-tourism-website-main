<template>
  <v-app>
      <NavBar />
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
  const NavBar = defineAsyncComponent(() => import('@/Components/components/NavBarComponent/NavBar.vue'));
  const DestinationContentComponent = defineAsyncComponent(() => import('@/Components/components/DestinationComponents/DestinationContentComponent.vue'));
  const ImageHandler = defineAsyncComponent(() => import('@/Components/props/GeneralProps/ImageHandlerProp/ImageHandler.vue'));  
  
  // ImageHandler prop images
  import BackgroundDestinationMobile from '@/assets/destination/background-destination-mobile.jpg';
  import BackgroundDestinationTablet from '@/assets/destination/background-destination-tablet.jpg';
  import BackgroundDestinationDesktop from '@/assets/destination/background-destination-desktop.jpg';
</script>
  