<template>
  <v-app>
    <CrewContentComponent />
    <NavBar />
    <ImageHandler 
      :mobileImage="BackgroundHomeMobile"
      :tabletImage="BackgroundHomeTablet"
      :desktopImage="BackgroundHomeDesktop"
    />
  </v-app>
</template>
  
<script setup>
  defineOptions({ name: 'CrewLayout' });
  import NavBar from '@/Components/components/NavBarComponent/NavBar.vue';
  import ImageHandler from '@/Components/props/GeneralProps/ImageHandlerProp/ImageHandler.vue';  
  import CrewContentComponent from '@/Components/components/CrewComponents/CrewContentComponent.vue'

  // ImageHandler prop images
  import BackgroundHomeMobile from '@/assets/crew/background-crew-mobile.jpg';
  import BackgroundHomeTablet from '@/assets/crew/background-crew-tablet.jpg';
  import BackgroundHomeDesktop from '@/assets/crew/background-crew-desktop.jpg';
</script>
  