<template>
  <v-container
    class="flex absolute top-0 left-0" 
    style="font-family: var(--ff-barlow-condensed);"
  >
    <v-row align="center" justify="space-between" class="w-full">
      <v-col cols="auto">
        <img 
           v-lazy="Logo"
          alt="Logo" 
          class="w-full h-full" 
        ></img>
      </v-col>
      
      <v-col cols="auto"> 
        <img 
          v-lazy="OpenDrawer"
          @click="drawer = !drawer" 
          alt="Open Menu" 
          class="w-full h-full" 
          aria-label="Open Menu"
        />
      </v-col>
    </v-row>
    
    <v-navigation-drawer 
      v-model="drawer" 
      temporary 
      app 
      :location="$vuetify.display.mobile ? 'right' : undefined"
      class="bg-transparent backdrop-blur-sm"
    >
      <v-list-item>
        <img 
          v-lazy="CloseDrawer"
          class="absolute right-2 m-3 w-5 h-5" 
          alt="Close Menu" 
          @click="drawer = !drawer"
          aria-label="Close Menu"
        />
      </v-list-item>

      <v-list density="default" width="100%" ripple rounded nav class="mt-20 text-white flex flex-column pl-8">
        <v-list-item value="home" to="/">
          <template v-slot:prepend>
            <p class="pr-3 font-bold text-base tracking-widest">00</p>
          </template>
          <template v-slot:default>
            <p class="ml-1 tracking-widest text-base font-thin">HOME</p>
          </template>
        </v-list-item>

        <v-list-item value="destination" to="/destination">
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
  defineOptions({ name: 'NavBar' });
  import Logo from '@/assets/shared/logo.svg';
  import OpenDrawer from '@/assets/shared/icon-hamburger.svg';
  import CloseDrawer from '@/assets/shared/icon-close.svg';

  import { ref } from 'vue';
  const drawer = ref(false);
</script>
