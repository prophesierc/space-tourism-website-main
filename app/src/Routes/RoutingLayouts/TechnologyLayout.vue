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
    defineOptions({ name: 'TechnologyLayout' });
    import { defineAsyncComponent } from 'vue';

    const NavBar = defineAsyncComponent(() => import('@/Components/components/NavBarComponent/NavBar.vue'));
    const ImageHandler = defineAsyncComponent(() => import('@/Components/props/GeneralProps/ImageHandlerProp/ImageHandler.vue'));  
    const TechnologyContentComponents = defineAsyncComponent(() => import('@/Components/components/TechnologyComponents/TechnologyContentComponents.vue'));  

    // ImageHandler prop images
    import BackgroundTechnologyMobile from '@/assets/technology/background-technology-mobile.jpg';
    import BackgroundTechnologyTablet from '@/assets/technology/background-technology-tablet.jpg';
    import BackgroundTechnologyDesktop from '@/assets/technology/background-technology-desktop.jpg';
</script>
    