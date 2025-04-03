<template>
  <div class="w-screen h-screen overflow-hidden">
    <v-app>
      <HomeContent />
      <NavBar :activeIndex="0" />
      <ImageHandler 
        :mobileImage="BackgroundHomeMobile"
        :tabletImage="BackgroundHomeTablet"
        :desktopImage="BackgroundHomeDesktop"
      />
    </v-app>
  </div>
</template>

<script setup>
  // import { defineAsyncComponent } from 'vue';
  defineOptions({ name: 'HomeLayout' });

  import NavBar from '@/Components/General/NavBar.vue';
  import ImageHandler from '@/Components/General/ImageHandler.vue';
  import HomeContent from '@/Components/HomeComponents/HomeContent.vue';

  // ImageHandler prop images
  import BackgroundHomeMobile from '/assets/home/background-home-mobile.jpg';
  import BackgroundHomeTablet from '/assets/home/background-home-tablet.jpg';
  import BackgroundHomeDesktop from '/assets/home/background-home-desktop.jpg';
</script>
