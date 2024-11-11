<template>
    <div v-if="getData?.crew" class="mt-10">
        <v-carousel
            :show-arrows="false"
            color="white"
            :cycle="true"
            interval="3500"
            :height="655"
            hide-delimiter-background
            hide-delimiters
            @change="updateCurrentIndex"
            v-model="currentIndex"
            aria-label="Crew member carousel"
        >

            <v-carousel-item
                v-for="(crew, index) in getData?.crew"
                :key="index">

                <div 
                    class="absolute bottom-0 left-0 w-full h-[150px] bg-gradient-to-b from-transparent to-black pointer-events-none">
                </div>

                <div class="text-center pb-5"> 
                    <h2 
                        class="text-[#8d8f93]"
                        style="font-family: var(--ff-bellefair)"
                        aria-label="Role of the crew member">
                        {{ crew?.role.toUpperCase() }}
                    </h2>

                    <h3 
                        class="text-white text-[22px] mb-5"
                        style="font-family: var(--ff-bellefair)"
                        aria-label="Name of the crew member">
                        {{ crew?.name.toUpperCase() }}
                    </h3>

                    <p
                        class="text-[16px] tracking-wide font-[300] text-[#d0d6f9] px-7"
                        style="font-family: var(--ff-barlow-condensed)"
                        aria-label="Biography of the crew member">
                        {{ crew?.bio }}
                    </p>
                </div>

                <img
                    :src="crew?.images?.png" 
                    :draggable="false"
                    :srcset="`${ crew?.images?.png } 480w, ${ crew?.images?.webp } 800w`"
                    sizes="(max-width: 600px) 500px, 800px" 
                    :alt="`${ crew?.name }'s image`"
                    class="absolute bottom-0 left-1/2 transform -translate-x-1/2 w-auto h-[375px] max-h-[500px]" 
                    aria-label="Image of the crew member"
                />

            </v-carousel-item>
        </v-carousel>

        <div class="absolute bottom-[56%] left-1/2 transform -translate-x-1/2 flex space-x-5">
            <span
                v-for="(crew, index) in getData?.crew"
                :key="index"
                class="w-3 h-3 rounded-full"
                :class="[currentIndex === index ? 'bg-white' : 'bg-white/50']"
                @click="currentIndex = index"
                aria-label="Select crew member"
            ></span>
        </div>
    </div>

    <div v-else 
        class='flex items-center justify-center h-64'>
        <v-progress-circular 
            indeterminate 
            color='amber'
            aria-label="Loading crew data"
        ></v-progress-circular>
    </div>
</template>

<script setup>
    defineOptions({ name: 'CrewCarousel' })
    import { FetchAPI } from '@/Composables/FetchAPI';
    import { ref, onMounted } from 'vue';

    const { getData, getRequest } = FetchAPI();
    const currentIndex = ref(0);

    onMounted(async () => 
    {
        getData.value = await getRequest('/crew');
    });

    const updateCurrentIndex = (index) =>
    {
        currentIndex.value = index;
    }
</script>
