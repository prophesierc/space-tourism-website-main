<template>
  <v-app>
    <main>
      <router-view />
      <NavBar />
      <DestinationsProps />
      <ImageHandler 
      :mobileImage="BackgroundDestinationMobile"
      :tabletImage="BackgroundDestinationTablet"
      :desktopImage="BackgroundDestinationDesktop"
      />
    </main>
  </v-app>
</template>

<script setup>
  import ImageHandler from '@/components/props/ImageHandlerProp/ImageHandler.vue';
  import NavBar from '@/components/components/NavBarComponent/NavBar.vue';
  import DestinationsProps from '@/components/props/DestinationProps/DestinationsProps.vue';

  //ImageHandler prop images
  import BackgroundDestinationMobile from '@/assets/destination/background-destination-mobile.jpg';
  import BackgroundDestinationTablet from '@/assets/destination/background-destination-tablet.jpg';
  import BackgroundDestinationDesktop from '@/assets/destination/background-destination-desktop.jpg';

  defineOptions({ name: 'Destination' });
</script>
