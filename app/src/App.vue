<template>
  <v-app>
    <main>
      <router-view />
      <HomeContent />
      <ImageHandler />
      <NavBar />
    </main>
  </v-app>
</template>

<script setup>
import ImageHandler from '@/components/ImageHandler.vue';
import NavBar from '@/components/NavBar.vue';
import HomeContent from '@/components/HomeComponents/HomeContent.vue';
defineOptions({ name: 'App' });
</script>
