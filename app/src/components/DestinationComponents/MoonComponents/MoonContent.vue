<template>
    <div id="moon__content__container" 
    class="flex flex-col absolute w-screen h-screen justify-center " 
    style="font-family: var(--ff-barlow-condensed);">
        <div id="content__container" 
        class="flex justify-center w-auto h-[34rem]">

            <span class=" flex text-[16px] tracking-widest text-[#d0d6f9]"
            style="font-family: var(--ff-barlow-condensed);">
                <span class="font-bold pr-5 text-[#53555f]">01</span>
                <span>PICK YOUR DESTINATION</span>
            </span>

        </div>
    </div>
</template>

<script setup>
    defineOptions({ name: 'MoonContent' });
    // may change to prop to keep all destinations standardized
</script>