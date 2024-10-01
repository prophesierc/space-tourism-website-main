<template>
  <v-container c
    class="flex absolute top-0 left-0" 
    style="font-family: var(--ff-barlow-condensed);">

    <v-row align="center" justify="space-between" 
      class="w-full">
        <v-col cols="auto">
          <img src="@/assets/shared/logo.svg" alt="Logo" class="w-full h-full" />
        </v-col>
      
        <v-col cols="auto"> 
            <img src="@/assets/shared/icon-hamburger.svg" 
              @click="drawer = !drawer" 
              alt="Open Menu" 
              class="w-full h-full" />
        </v-col>
    </v-row>
    
    <v-navigation-drawer v-model="drawer" 
      temporary app :location="$vuetify.display.mobile ? 'right' : undefined"
      class="bg-transparent backdrop-blur-sm">

      <v-list-item>
        <img src="@/assets/shared/icon-close.svg" 
          class="absolute right-2 m-3 w-5 h-5" 
          alt="Close Modal Icon" 
          @click="drawer = !drawer">
      </v-list-item>

      <v-list density="default" width=100% ripple rounded nav 
        class="mt-20 text-white flex flex-column pl-8">
      
      <v-list-item value="home">
        <template v-slot:prepend>
          <p class="pr-3 font-bold text-base tracking-widest">00</p>
        </template>
        <template v-slot:default>
          <p class="ml-1 tracking-widest text-base font-thin">HOME</p>
        </template>
      </v-list-item>

      <v-list-item value="destination">
        <template v-slot:prepend>
          <p class="pr-3 font-bold text-base tracking-widest">01</p>
        </template>
        <template v-slot:default>
          <p class="ml-1 tracking-widest text-lg font-thin">DESTINATION</p>
        </template>
      </v-list-item>

      <v-list-item value="crew">
        <template v-slot:prepend>
          <p class="pr-3 font-bold text-base tracking-widest">02</p>
        </template>
        <template v-slot:default>
          <p class="ml-1 tracking-widest text-lg font-thin">CREW</p>
        </template>
      </v-list-item>

      <v-list-item value="technology">
        <template v-slot:prepend>
          <p class="pr-3 font-bold text-base tracking-widest">03</p>
        </template>
        <template v-slot:default>
          <p class="ml-1 tracking-widest text-lg font-thin">TECHNOLOGY</p>
        </template>
      </v-list-item>

      </v-list>
    </v-navigation-drawer>
  </v-container>
</template>

<script setup>
import { ref } from 'vue';
const drawer = ref(false);

defineOptions({ name: 'NavBar' });
</script>