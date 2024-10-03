<template>
  <v-app>
    <main>
      <NavBar />
      <DestinationsProps :index="0" />
      <ImageHandler 
        :mobileImage="BackgroundDestinationMobile"
        :tabletImage="BackgroundDestinationTablet"
        :desktopImage="BackgroundDestinationDesktop"
      />
    </main>
  </v-app>
</template>

<script setup>
  import NavBar from '@/components/components/NavBarComponent/NavBar.vue';
  import DestinationsProps from '@/components/props/DestinationProps/DestinationsProps.vue';
  import ImageHandler from '@/components/props/ImageHandlerProp/ImageHandler.vue';

  // ImageHandler prop images
  import BackgroundDestinationMobile from '@/assets/destination/background-destination-mobile.jpg';
  import BackgroundDestinationTablet from '@/assets/destination/background-destination-tablet.jpg';
  import BackgroundDestinationDesktop from '@/assets/destination/background-destination-desktop.jpg';
</script>
