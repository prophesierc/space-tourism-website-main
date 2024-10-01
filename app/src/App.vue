<template>
  <v-app>
    <main>
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
</script>
