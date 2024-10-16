<template>
    <div v-if="postData['crew']" class="mt-10">
        <v-carousel
            :show-arrows="false"
            color="white"
            :cycle="true"
            interval="3500"
            :height="655"
            hide-delimiter-background
            hide-delimiters
            @change="updateCurrentIndex"
            v-model="currentIndex">

            <v-carousel-item
                v-for="(crew, index) in postData['crew']"
                :key="index">

                <div 
                    class="absolute bottom-0 left-0 w-full h-[150px] bg-gradient-to-b from-transparent to-black pointer-events-none">
                </div>

                <div class="text-center pb-5"> 
                    <h2 
                        class="text-[#8d8f93]"
                        style="font-family: var(--ff-bellefair)">
                        {{ crew.role.toUpperCase() }}
                    </h2>

                    <h3 
                        class="text-white text-[22px] mb-5"
                        style="font-family: var(--ff-bellefair)">
                        {{ crew.name.toUpperCase() }}
                    </h3>

                    <p
                        class="text-[16px] tracking-wide font-[300] text-[#d0d6f9] px-7"
                        style="font-family: var(--ff-barlow-condensed)">
                        {{ crew.bio }}
                    </p>
                </div>

                <img
                    :src="crew.images.png" 
                    :alt="`${crew.name}'s image`"
                    class="absolute bottom-0 left-1/2 transform -translate-x-1/2 w-auto h-[375px] max-h-[500px]" 
                />
                <!-- :srcset="`${crew.images.png} 480w, ${crew.images.webp} 800w`"
                    sizes="(max-width: 600px) 500px, 800px" -->
                <!-- max-h-[500px] controls the height of the images on growth -->

            </v-carousel-item>
        </v-carousel>

        <div class="absolute bottom-[56%] left-1/2 transform -translate-x-1/2 flex space-x-5">
            <span
                v-for="(crew, index) in postData['crew']"
                :key="index"
                class="w-3 h-3 bg-white/50 rounded-full"
                :class="{ 'bg-white': currentIndex === index }"
                @click="currentIndex = index"
            ></span>
            <!-- needs media query to change position at 600px -->
        </div>
    </div>
</template>
  
<script setup>
    defineOptions({ name: 'CrewCarousel' })
    import { FetchAPI } from '@/Composables/FetchAPI';
    import { ref } from 'vue';

    const { postData } = FetchAPI();
    const currentIndex = ref(0);
    function updateCurrentIndex(index) 
    {
        currentIndex.value = index;
    }
</script>
