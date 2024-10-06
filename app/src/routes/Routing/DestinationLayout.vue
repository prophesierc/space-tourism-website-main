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
    import NavBar from '@/Components/components/NavBarComponent/NavBar.vue';
    import DestinationContentComponent from '@/Components/components/DestinationComponents/DestinationContentComponent.vue';
    import ImageHandler from '@/Components/props/ImageHandlerProp/ImageHandler.vue';
  
    // ImageHandler prop images
    import BackgroundDestinationMobile from '@/assets/destination/background-destination-mobile.jpg';
    import BackgroundDestinationTablet from '@/assets/destination/background-destination-tablet.jpg';
    import BackgroundDestinationDesktop from '@/assets/destination/background-destination-desktop.jpg';
  
  </script>
  