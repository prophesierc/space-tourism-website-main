<template>
    <div class="mt-10 h-[300px] w-auto bg-red">
        <v-carousel
            :show-arrows="false"
            color="white"
            hide-delimiter-background
            @change="updateCurrentIndex"
            v-model="currentIndex">

            <v-carousel-item 
                v-for="(tech, index) in getData.technology"
                :key="index"
                class="bg-yellow h-auto">

                <img
                    :src="tech.images.portrait" 
                    :srcset="`${tech.images.portrait} 480w, ${tech.images.landscape} 100w`"
                    sizes="(max-width: 700px) 500px, 800px" 
                    :alt="`${tech.name}'s image`"
                    class="object-none object-bottom w-auto h-auto bg-green"
                />

            </v-carousel-item>

        </v-carousel>
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