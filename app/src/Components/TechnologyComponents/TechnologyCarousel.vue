<template>
    <div class="flex flex-col justify-center align-center h-screen w-auto">
        <v-carousel
            :show-arrows="false"
            color="white"
            hide-delimiter-background
            hide-delimiters
            class="flex justify-center align-center">

            <v-carousel-item>
                <img
                    src="@/assets/technology/image-launch-vehicle-portrait.jpg" 
                    class="object-none object-bottom w-auto h-auto"
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