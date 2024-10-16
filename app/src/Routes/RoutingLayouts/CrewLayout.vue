<template>
  <div class="w-screen h-screen overflow-hidden">
    <!-- allows v-app stylings to prevent overflow due to imageHandler -->
    <v-app>
      <CrewContentComponent />
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
  defineOptions({ name: 'CrewLayout' });
  import { defineAsyncComponent } from 'vue';

  const NavBar = defineAsyncComponent(() => import('@/Components/components/NavBarComponent/NavBar.vue'));
  const ImageHandler = defineAsyncComponent(() => import('@/Components/props/GeneralProps/ImageHandlerProp/ImageHandler.vue'));  
  const CrewContentComponent = defineAsyncComponent(() => import('@/Components/components/CrewComponents/CrewContentComponent.vue'));  

  // ImageHandler prop images
  import BackgroundHomeMobile from '@/assets/crew/background-crew-mobile.jpg';
  import BackgroundHomeTablet from '@/assets/crew/background-crew-tablet.jpg';
  import BackgroundHomeDesktop from '@/assets/crew/background-crew-desktop.jpg';
</script>
  