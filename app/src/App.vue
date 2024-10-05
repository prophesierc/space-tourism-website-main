<template>
  <v-app>
    <main>
      <router-view v-slot="{ Component }">
        <keep-alive>
          <component :is="Component" />
        </keep-alive>
      </router-view>
      <NavBar />
      <HomeContent />
      <ImageHandler 
        :mobileImage="BackgroundHomeMobile"
        :tabletImage="BackgroundHomeTablet"
        :desktopImage="BackgroundHomeDesktop"
      />
    </main>
  </v-app>
</template>

<script setup>
  defineOptions({ name: 'App' });
  import ImageHandler from '@/components/props/ImageHandlerProp/ImageHandler.vue';
  import NavBar from '@/components/components/NavBarComponent/NavBar.vue';
  import HomeContent from '@/components/components/HomeComponents/HomeContent.vue';

  // ImageHandler prop images
  import BackgroundHomeMobile from '@/assets/home/background-home-mobile.jpg';
  import BackgroundHomeTablet from '@/assets/home/background-home-tablet.jpg';
  import BackgroundHomeDesktop from '@/assets/home/background-home-desktop.jpg';
</script>
