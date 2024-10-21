<template>
  <div class="w-screen h-screen overflow-hidden">
    <v-app>
      <HomeContent />
      <NavBar />
      <ImageHandler 
        :mobileImage="BackgroundHomeMobile"
        :tabletImage="BackgroundHomeTablet"
        :desktopImage="BackgroundHomeDesktop"
      />
    </v-app>
  </div>
</template>

<script setup>
  import { defineAsyncComponent } from 'vue';
  defineOptions({ name: 'HomeLayout' });

  const ImageHandler = defineAsyncComponent(() =>
    import('@/Components/props/GeneralProps/ImageHandlerProp/ImageHandler.vue')
  );
  const NavBar = defineAsyncComponent(() =>
    import('@/Components/components/NavBarComponent/NavBar.vue')
  );
  const HomeContent = defineAsyncComponent(() =>
    import('@/Components/components/HomeComponents/HomeContent.vue')
  );

  // ImageHandler prop images
  import BackgroundHomeMobile from '/assets/home/background-home-mobile.jpg';
  import BackgroundHomeTablet from '/assets/home/background-home-tablet.jpg';
  import BackgroundHomeDesktop from '/assets/home/background-home-desktop.jpg';
</script>
