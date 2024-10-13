<template>
    <div 
        id="crew__content__container" 
        class="flex flex-col absolute w-full h-full items-center mt-[6em]" 
        style="font-family: var(--ff-barlow-condensed);">

        <div v-if="postData['crew']"
            class="flex flex-col justify-center items-center text-center h-screen w-full"> 

            <Header :pageNumber="crewPage" :intro="crewintro" />

            <div class="flex flex-col font-[100] h-64 justify-end">
                <h2 
                    class="text-[#8d8f93] pb-3 "
                    style="font-family: var(--ff-bellefair)">
                    {{ postData['crew'][0].role.toUpperCase() }}
                    <!-- temp data fetch -->
                </h2>
    
                <h3 
                    class="text-white text-[22px] mb-8"
                    style="font-family: var(--ff-bellefair)">
                    {{ postData['crew'][0].name.toUpperCase() }}
                    <!-- temp data fetch -->
                </h3>

                <p 
                    class="text-[16px] text-center mx-8 tracking-wide font-[300] text-[#d0d6f9]"
                    style="font-family: var(--ff-barlow-condensed)">
                    {{ postData['crew'][0].bio }}
                    <!-- temp data fetch -->
                </p>

                
                
                <CrewCarousel />
            </div>
            
        </div>
    </div>  
</template>

<script setup>
    defineOptions({ name: 'CrewContentComponent' })
    import CrewCarousel from '@/Components/components/CrewComponents/CrewCarousel.vue'
    import Header from '@/Components/props/GeneralProps/Header/Header.vue'
    import { FetchAPI } from '@/Composables/FetchAPI';

    const crewPage = "02"; 
    const crewintro = "MEET YOUR CREW";
    const { postData } = FetchAPI();
</script>
