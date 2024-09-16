<template>
  <v-app>
    <main class="relative w-screen h-screen overflow-hidden">
      <NavBar class="absolute top-0 left-0 z-10 w-full" />
      <ImageHandler class="absolute top-0 left-0 w-full h-full z-0" />
    </main>
  </v-app>
</template>

<script setup>
import ImageHandler from '@/components/ImageHandler.vue';
import NavBar from '@/components/NavBar.vue';
</script>
