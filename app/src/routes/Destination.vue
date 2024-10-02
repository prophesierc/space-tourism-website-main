<template>
  <v-app>
    <main>
      <router-view />
      <ImageHandler 
        mobileImage="@/assets/home/background-home-mobile.jpg"
        tabletImage="@/assets/home/background-home-tablet.jpg" 
        desktopImage="@/assets/home/background-home-desktop.jpg"
      />
      <NavBar />
    </main>
  </v-app>
</template>

<script setup>
import ImageHandler from '@/components/ImageHandler.vue';
import NavBar from '@/components/NavBar.vue';
defineOptions({ name: 'Destination' });
</script>
