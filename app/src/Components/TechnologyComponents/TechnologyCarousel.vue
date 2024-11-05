<template>
    <div v-if="getData?.technology" class="mt-10">
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

        <div class="absolute bottom-[56%] left-1/2 transform -translate-x-1/2 flex space-x-5">
            <span
                v-for="(tech, index) in getData?.technology"
                :key="index"
                class="w-3 h-3 bg-white/50 rounded-full"
                :class="{ 'bg-white': currentIndex === index }"
                @click="currentIndex = index"
            ></span>
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