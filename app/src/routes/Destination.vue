<template>
  <v-app>
    <main>
      <router-view />
      <ImageHandler />
      <NavBar />
    </main>
  </v-app>
</template>

<script setup>
import ImageHandler from '@/components/ImageHandler.vue';
import NavBar from '@/components/NavBar.vue';
import HomeContent from '@/components/HomeComponents/HomeContent.vue';
defineOptions({ name: 'Destination' });
</script>
