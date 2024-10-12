<template>
    <div 
        id="crew__content__container" 
        class="flex flex-col absolute w-full h-full items-center mt-[6em]" 
        style="font-family: var(--ff-barlow-condensed);">
        <Header :pageNumber="crewPage" :intro="crewintro" />
    </div>  
</template>

<script setup>
    defineOptions({name: 'CrewContentComponent'})
    import Header from '@/Components/props/GeneralProps/Header/Header.vue'
    const crewPage = "02"; // Default to Moon
    const crewintro = "MEET YOUR CREW"; // Default to Moon

</script>