<template>
    <div id="home__content__container" 
        class="absolute w-auto h-screen flex flex-col justify-center" 
        style="font-family: var(--ff-barlow-condensed);">
        <div id="content__container" 
            class="flex flex-col justify-center items-center m-4 min-[768px]:items-start min-[768px]:w-[445px] min-[768px]:ml-20 min-[768px]:mt-20">

            <h1 
                class="flex text-[16px] tracking-widest text-[#d0d6f9] 
                min-[526px]:mt-20 min-[768px]:text-[22px]" 
                aria-label="Introductory text about traveling to space">
                    SO, YOU WANT TO TRAVEL TO
            </h1>

            <h2 
                class="text-[80px] tracking-tight text-white min-[768px]:text-[100px]" 
                style="font-family: var(--ff-bellefair)" 
                aria-label="Main title indicating the destination">
                    SPACE
            </h2>

            <p 
                class="text-[15px] text-[#d0d6f9] tracking-[.08em] font-[300] pt-5 max-[768px]:text-center min-[768px]:text-left" 
                aria-label="Description of the space travel experience">
                    Let’s face it; if you want to go to space, you might as well genuinely go to 
                    outer space and not hover kind of on the edge of it. Well sit back, and relax 
                    because we’ll give you a truly out of this world experience!
                </p>
                    <HomeExploreButton aria-label="Explore space button"/>
            </div>
        </div>
</template>

<script setup>
  defineOptions({ name: 'HomeContent' });
  import { defineAsyncComponent } from 'vue';
  
  const HomeExploreButton = defineAsyncComponent(() => 
    import('@/Components/HomeComponents/HomeExploreButton.vue'));
</script>
