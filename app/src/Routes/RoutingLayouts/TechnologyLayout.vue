<template>
    <v-app>
        <NavBar :activeIndex="3" />
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

    const NavBar = defineAsyncComponent(() => 
     import('@/Components/General/NavBar.vue'));

    const ImageHandler = defineAsyncComponent(() => 
     import('@/Components/General/ImageHandler.vue'));  
     
    const TechnologyContentComponents = defineAsyncComponent(() => 
        import('@/Components/TechnologyComponents/TechnologyContentComponents.vue'));  

    // ImageHandler prop images
    import BackgroundTechnologyMobile from '/assets/technology/background-technology-mobile.jpg';
    import BackgroundTechnologyTablet from '/assets/technology/background-technology-tablet.jpg';
    import BackgroundTechnologyDesktop from '/assets/technology/background-technology-desktop.jpg';
</script>
    