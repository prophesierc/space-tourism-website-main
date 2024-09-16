<template>
  <div class="p-4 flex justify-between items-center border-none outline-none">
    <v-btn  class="bg-transparent w-full h-full">
      <img src="@/assets/shared/logo.svg" class="absolute left-0 w-8 h-8" alt="Left Icon">
      <img src="@/assets/shared/icon-hamburger.svg" @click="drawer = !drawer" class="absolute right-0 w-8 h-8" alt="Right Icon">
    </v-btn>

    <v-navigation-drawer v-model="drawer" temporary app>

      <v-list-item>
        <img src="@/assets/shared/icon-close.svg" class="absolute right-4 w-5 h-5" alt="Left Icon" @click="drawer = !drawer">
      </v-list-item>

      <v-list density="compact" nav>
        <v-list-item prepend-icon="mdi-view-dashboard" title="HOME" value="home">
        </v-list-item>
        <v-list-item prepend-icon="mdi-forum" title="DESTINATION" value="destination">
        </v-list-item>
        <v-list-item prepend-icon="mdi-forum" title="CREW" value="crew">
        </v-list-item>
        <v-list-item prepend-icon="mdi-forum" title="TECHNOLOGY" value="technology">
        </v-list-item>
      </v-list>
    </v-navigation-drawer>
  </div>
</template>

<script setup>
import { ref } from 'vue';
const drawer = ref(false);

defineOptions({ name: 'NavBar' });
</script>
