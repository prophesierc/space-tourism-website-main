<template>
    <div id="home__content__container" 
        class="absolute w-auto h-screen flex flex-col justify-center" 
        style="font-family: var(--ff-barlow-condensed);">
        <div id="content__container" 
            class="flex flex-col justify-center align-center m-4">

            <h1 class="text-[16px] tracking-widest text-[#d0d6f9] min-[526px]:mt-20" aria-label="Introductory text about traveling to space">
                SO, YOU WANT TO TRAVEL TO
            </h1>

            <h2 class="text-[80px] tracking-tight text-white" 
                style="font-family: var(--ff-bellefair)" aria-label="Main title indicating the destination">
                SPACE
            </h2>

            <p class="text-[15px] text-[#d0d6f9] text-center tracking-[.08em] font-[300] pt-5" 
                aria-label="Description of the space travel experience">
                Let’s face it; if you want to go to space, you might as well genuinely go to 
                outer space and not hover kind of on the edge of it. Well sit back, and relax 
                because we’ll give you a truly out of this world experience!
            </p>
            <HomeExploreButton aria-label="Explore space button" />
        </div>
    </div>
</template>

<script setup>
  defineOptions({ name: 'HomeContent' });
  import { defineAsyncComponent } from 'vue';
  
  const HomeExploreButton = defineAsyncComponent(() => 
    import('@/Components/HomeComponents/HomeExploreButton.vue'));
</script>
