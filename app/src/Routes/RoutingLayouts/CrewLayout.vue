<template>
  <div class="w-screen h-screen overflow-hidden">
    <!-- allows v-app stylings to prevent overflow due to imageHandler -->
    <v-app>
      <CrewContentComponent />
      <NavBar :activeIndex="2" />
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

  const NavBar = defineAsyncComponent(() => 
    import('@/Components/General/NavBar.vue'));

  const ImageHandler = defineAsyncComponent(() => 
    import('@/Components/General/ImageHandler.vue')); 

  const CrewContentComponent = defineAsyncComponent(() => 
    import('@/Components/CrewComponents/CrewContentComponent.vue'));  

  // ImageHandler prop images
  import BackgroundHomeMobile from '@/assets/crew/background-crew-mobile.jpg';
  import BackgroundHomeTablet from '@/assets/crew/background-crew-tablet.jpg';
  import BackgroundHomeDesktop from '@/assets/crew/background-crew-desktop.jpg';
</script>
  