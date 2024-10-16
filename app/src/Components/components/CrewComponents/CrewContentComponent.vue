<template>
    <div 
        id="crew__content__container" 
        class="flex flex-col absolute w-full items-center mt-[6em]" 
        style="font-family: var(--ff-barlow-condensed);">

        <div> 

            <Header :pageNumber="crewPage" :intro="crewintro" />
            <CrewCarousel />
            
        </div>
    </div>  
</template>

<script setup>
    defineOptions({ name: 'CrewContentComponent' })
    import { defineAsyncComponent } from 'vue';

    const Header = defineAsyncComponent(() => import('@/Components/props/GeneralProps/Header/Header.vue'));  
    const CrewCarousel = defineAsyncComponent(() => import('@/Components/components/CrewComponents/CrewCarousel.vue'));  

    const crewPage = "02"; 
    const crewintro = "MEET YOUR CREW";
</script>
