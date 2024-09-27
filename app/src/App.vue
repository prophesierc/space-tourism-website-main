<template>
  <v-app>
    <main>
      <ImageHandler />
      <NavBar />
      <HomeContent />
    </main>
  </v-app>
</template>

<script setup>
import ImageHandler from '@/components/ImageHandler.vue';
import NavBar from '@/components/NavBar.vue';
import HomeContent from '@/components/HomeContent.vue';
</script>
