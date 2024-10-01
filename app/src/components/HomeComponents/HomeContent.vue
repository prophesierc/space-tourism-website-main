<template>
    <div id="home__content__container" 
    class="absolute w-auto h-screen flex flex-col justify-center  " 
    style="font-family: var(--ff-barlow-condensed);">
        <div id="content__container" 
        class="flex flex-col justify-center align-center m-4 pt-10 h-[40rem]">

            <h1 class="text-[16px] tracking-widest text-[#d0d6f9]">
                SO, YOU WANT TO TRAVEL TO
            </h1>

            <h2 class="text-[80px] tracking-tight text-white" 
            style="font-family: var(--ff-bellefair)">
                SPACE
            </h2>

            <p class="text-[15px] text-[#d0d6f9] text-center tracking-[.08em] font-thin">
                Let’s face it; if you want to go to space, you might as well genuinely go to 
                outer space and not hover kind of on the edge of it. Well sit back, and relax 
                because we’ll give you a truly out of this world experience!
            </p>
            <HomeExploreButton />
        </div>
    </div>
</template>


<script setup>
  import HomeExploreButton from '@/components/HomeComponents/HomeExploreButton.vue';
  defineOptions({ name: 'HomeContent'});
</script>