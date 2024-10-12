<template>
    <div 
        id="header__container" 
        class="flex flex-col items-center mb-auto w-auto">
        <span 
            class="flex text-[16px] tracking-widest ">
            <span 
                class="font-bold pr-5 text-[#53555f]"
                > {{ pageNumber }} 
            </span>
            <h1 
                class="text-white"
                > {{ intro }}
            </h1>
        </span>
    </div>
</template>

<script setup>
    defineOptions({ name: 'Header' })
    defineProps(
    { 
        pageNumber: String,  
        intro: String,  
    })
</script>