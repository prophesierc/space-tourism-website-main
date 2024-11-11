<template>
    <div 
        id="crew__content__container" 
        class="flex flex-col absolute w-full items-center mt-[6em]" 
        style="font-family: var(--ff-barlow-condensed);">

        <div> 

            <Header 
                :pageNumber="crewPage" 
                :intro="crewIntro" 
                aria-labelledby="crew-header" 
            />
            <CrewCarousel aria-label="Crew carousel showing team members" />
            
        </div>
    </div>  
</template>

<script setup>
    defineOptions({ name: 'CrewContentComponent' })
    import { defineAsyncComponent } from 'vue';

    const Header = defineAsyncComponent(() => 
        import('@/Components/General/Header.vue'));    

    const CrewCarousel = defineAsyncComponent(() => 
        import('@/Components/CrewComponents/CrewCarousel.vue'));  

    const crewPage = "02"; 
    const crewIntro = "MEET YOUR CREW";
</script>
