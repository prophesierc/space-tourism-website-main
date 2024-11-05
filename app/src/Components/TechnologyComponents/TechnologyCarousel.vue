<template>
    <div v-if="getData?.technology" 
        class="flex flex-col align-center mt-10">
        <v-carousel
            :show-arrows="false"
            color="white"
            hide-delimiter-background
            hide-delimiters
            height="425"
            @change="updateCurrentIndex"
            v-model="currentIndex">

            <v-carousel-item 
                v-for="(tech, index) in getData?.technology"
                :key="index">

                <img
                    :src="tech.images.portrait" 
                    :draggable="false"
                    :srcset="`${tech.images.portrait} 480w, ${tech.images.landscape} 100w`"
                    sizes="(max-width: 373px) 500px, 600px" 
                    :alt="`${tech.name}'s image`"
                    class="object-none object-bottom"
                />  

            </v-carousel-item>           
        </v-carousel>

        <div class="flex flex-row w-full justify-center align-end h-10 pb-5 space-x-5 ">
            <span
                v-for="(tech, index) in getData?.technology"
                :key="index"
                class="w-10 h-10 rounded-full text-center 
                    flex flex-col justify-center text-white "
                :class="{ 'bg-white text-red ': currentIndex === index }"
                @click="currentIndex = index"
            >{{index}}</span>
                    
        </div>  
    </div>
    
</template>

<script setup>
    defineOptions({ name: 'TechnologyCarousel' })
    import { FetchAPI } from '@/Composables/FetchAPI';
    import { ref, onMounted } from 'vue';

    const { getData, getRequest } = FetchAPI();
    const currentIndex = ref(0);

    onMounted(async () => 
    {
        getData.value = await getRequest('/technology');
    });

    function updateCurrentIndex(index) 
    {
        currentIndex.value = index;
    }
</script>