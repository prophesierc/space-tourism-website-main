<template>
  <v-app class="min-[525px]:overflow-hidden">
    <div class="relative min-h-screen">
      <ImageHandler
      class="absolute"
      :mobileImage="BackgroundDestinationMobile"
      :tabletImage="BackgroundDestinationTablet"
      :desktopImage="BackgroundDestinationDesktop"
      />
      <NavBar :activeIndex="1" />
      <DestinationContentComponent />
    </div>
  </v-app>
</template>

<script setup>
  defineOptions({ name: 'DestinationLayout' });
  // import { defineAsyncComponent } from 'vue';

  import NavBar from '@/Components/General/NavBar.vue';
  import DestinationContentComponent from '@/Components/DestinationComponents/DestinationContentComponent.vue';
  import ImageHandler from '@/Components/General/ImageHandler.vue';

  
  // ImageHandler prop images
  import BackgroundDestinationMobile from '/assets/destination/background-destination-mobile.jpg';
  import BackgroundDestinationTablet from '/assets/destination/background-destination-tablet.jpg';
  import BackgroundDestinationDesktop from '/assets/destination/background-destination-desktop.jpg';
</script>
  