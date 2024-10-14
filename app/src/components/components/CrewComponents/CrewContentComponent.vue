<template>
    <div 
        id="crew__content__container" 
        class="flex flex-col absolute w-full items-center mt-[6em] " 
        style="font-family: var(--ff-barlow-condensed);">

        <div> 

            <Header :pageNumber="crewPage" :intro="crewintro" />
            <CrewCarousel />
            
        </div>
    </div>  
</template>

<script setup>
    defineOptions({ name: 'CrewContentComponent' })
    import CrewCarousel from '@/Components/components/CrewComponents/CrewCarousel.vue'
    import Header from '@/Components/props/GeneralProps/Header/Header.vue'

    const crewPage = "02"; 
    const crewintro = "MEET YOUR CREW";
</script>
