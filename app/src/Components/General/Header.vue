<template>
    <div 
        id="header__container" 
        class="flex flex-col items-center mb-auto w-screen 
            min-[526px]:items-start min-[526px]:ml-10"
        >
        <span 
            class="flex text-[16px] tracking-widest " 
            aria-label="Page number and introduction text">
            <span 
                class="font-bold pr-5 text-[#55575e]"
                > {{ pageNumber }} 
            </span>
            <h1 
                class="text-white text-[100]"
                aria-label="Introduction text: {{ intro }}"
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
