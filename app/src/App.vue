<template>
  <v-app>
    <main>
      <HomeContent />
      <router-view v-slot="{ Component }">
        <keep-alive>
          <component :is="Component" />
        </keep-alive>
      </router-view>
      <NavBar />
    </main>
    <ImageHandler 
    :mobileImage="BackgroundHomeMobile"
    :tabletImage="BackgroundHomeTablet"
    :desktopImage="BackgroundHomeDesktop"
    />
  </v-app>
</template>

<script setup>
  defineOptions({ name: 'App' });

  import ImageHandler from '@/Components/props/ImageHandlerProp/ImageHandler.vue';
  import NavBar from '@/Components/components/NavBarComponent/NavBar.vue';
  import HomeContent from '@/Components/components/HomeComponents/HomeContent.vue';

  // ImageHandler prop images
  import BackgroundHomeMobile from '@/assets/home/background-home-mobile.jpg';
  import BackgroundHomeTablet from '@/assets/home/background-home-tablet.jpg';
  import BackgroundHomeDesktop from '@/assets/home/background-home-desktop.jpg';
</script>
