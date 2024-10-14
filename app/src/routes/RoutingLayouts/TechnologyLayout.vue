<template>
    <v-app>
        <NavBar />
        <TechnologyContentComponents />
        <ImageHandler 
        :mobileImage="BackgroundTechnologyMobile"
        :tabletImage="BackgroundTechnologyTablet"
        :desktopImage="BackgroundTechnologyDesktop"
        />
    </v-app>
</template>
    
<script setup>
    defineOptions({ name: 'CrewLayout' });
    import NavBar from '@/Components/components/NavBarComponent/NavBar.vue';
    import ImageHandler from '@/Components/props/GeneralProps/ImageHandlerProp/ImageHandler.vue';  
    import TechnologyContentComponents from '@/Components/components/TechnologyComponents/TechnologyContentComponents.vue'
  
    // ImageHandler prop images
    import BackgroundTechnologyMobile from '@/assets/technology/background-technology-mobile.jpg';
    import BackgroundTechnologyTablet from '@/assets/technology/background-technology-tablet.jpg';
    import BackgroundTechnologyDesktop from '@/assets/technology/background-technology-desktop.jpg';
</script>
    