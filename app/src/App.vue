<template>
  <v-app>
    <main>
      <router-view />
      <NavBar />
      <HomeContent />
      <ImageHandler 
        :mobileImage="BackgroundHomeMobile"
        :tabletImage="BackgroundHomeTablet"
        :desktopImage="BackgroundHomeDesktop"
      />
    </main>
  </v-app>
</template>

<script setup>
  import ImageHandler from '@/components/ImageHandler.vue';
  import NavBar from '@/components/NavBar.vue';
  import HomeContent from '@/components/HomeComponents/HomeContent.vue';

  //ImageHandler prop images
  import BackgroundHomeMobile from '@/assets/home/background-home-mobile.jpg';
  import BackgroundHomeTablet from '@/assets/home/background-home-tablet.jpg';
  import BackgroundHomeDesktop from '@/assets/home/background-home-desktop.jpg';

  defineOptions({ name: 'App' });
</script>
