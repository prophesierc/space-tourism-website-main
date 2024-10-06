<template>
    <v-app>
        <HomeContent />
        <NavBar />
      <ImageHandler 
      :mobileImage="BackgroundHomeMobile"
      :tabletImage="BackgroundHomeTablet"
      :desktopImage="BackgroundHomeDesktop"
      />
    </v-app>
  </template>
  
  <script setup>
    defineOptions({ name: 'Layout' });
  
    import ImageHandler from '@/Components/props/ImageHandlerProp/ImageHandler.vue';
    import NavBar from '@/Components/components/NavBarComponent/NavBar.vue';
    import HomeContent from '@/Components/components/HomeComponents/HomeContent.vue';
  
    // ImageHandler prop images
    import BackgroundHomeMobile from '@/assets/home/background-home-mobile.jpg';
    import BackgroundHomeTablet from '@/assets/home/background-home-tablet.jpg';
    import BackgroundHomeDesktop from '@/assets/home/background-home-desktop.jpg';
  </script>
  