<template>
  <v-app>
    <main>
      <router-view />
      <NavBar />
      <MoonContent />
      <ImageHandler 
      :mobileImage="BackgroundDestinationMobile"
      :tabletImage="BackgroundDestinationTablet"
      :desktopImage="BackgroundDestinationDesktop"
      />
    </main>
  </v-app>
</template>

<script setup>
  import ImageHandler from '@/components/props/ImageHandler.vue';
  import NavBar from '@/components/NavBar.vue';
  import MoonContent from '@/components/DestinationComponents/MoonComponents/MoonContent.vue';

  //ImageHandler prop images
  import BackgroundDestinationMobile from '@/assets/destination/background-destination-mobile.jpg';
  import BackgroundDestinationTablet from '@/assets/destination/background-destination-tablet.jpg';
  import BackgroundDestinationDesktop from '@/assets/destination/background-destination-desktop.jpg';

  defineOptions({ name: 'Destination' });
</script>
