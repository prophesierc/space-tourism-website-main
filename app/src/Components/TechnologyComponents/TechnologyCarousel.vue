<template>
    <div 
        v-if="getData?.technology" 
        class="absolute w-full pt-20 flex flex-col align-center justify-center">
        <!-- need to fit page to vh -->
    
        <div 
            class="relative w-full flex flex-col min-[768px]:flex-row align-center justify-center h-[75vh]">
            <v-carousel
                :show-arrows="false"
                color="white"
                :cycle="false"
                interval="3500"
                hide-delimiter-background
                hide-delimiters
                height="300"
                @change="updateCurrentIndex"
                v-model="currentIndex"
                class="min-[768px]:order-3">
    
                <v-carousel-item 
                    v-for="(tech, index) in getData?.technology"
                    :key="index">
                    <div class="flex flex-row align-center justify-end h-[100%] w-[100%]">
                        <img 
                            :src="index <= 1 ? tech?.images?.portrait : tech?.images?.landscape" 
                            :draggable="false"
                            :alt="`${tech?.name}'s image`"
                            :class="[ 
                                'h-[85%] w-[100%] object-cover min-[768px]:h-[300px] min-[768px]:w-[40vw] ',
                                index === 0 ? 'max-[616px]:object-[0%_100%] min-[616px]:object-[0%_-200px] min-[768px]:object-[50%_50%]' : '',
                                index === 1 ? 'max-[616px]:object-[50%_50%] min-[616px]:object-[0%_80%]' : '',
                                index === 2 ? 'max-[616px]:object-[80%_0%]' : ''
                                // need to adjust fit of images at desktop
                            ]"
                        />
                    </div>
                </v-carousel-item>

                <template v-slot:placeholder>
                    <div class="flex align-center justify-center items-center fill-height">
                      <v-progress-circular
                        color="amber"
                        indeterminate
                        aria-label="Loading destination image"
                      ></v-progress-circular>
                    </div>
                </template>
            </v-carousel>

            <div class="flex justify-center items-center pt-5 min-[768px]:order-1 pl-10">
                <div class="flex min-[768px]:space-x-0 space-x-5 min-[768px]:flex-col">
                    <button
                        v-for="(tech, index) in getData?.technology"
                        :key="index"
                        style="font-family: var(--ff-bellefair)"
                        class="w-10 h-10 rounded-full flex items-center justify-center mt-5 "
                        :class="[ 
                            currentIndex === index 
                            ? 'bg-white text-black' 
                            : 'bg-transparent text-white border-[1px] border-solid border-white '
                        ]"
                        @click="currentIndex = index"
                            >{{ index + 1 }}
                    </button>
                </div>
            </div>

            <div 
                class="flex flex-col text-center justify-center align-center w-full min-[768px]:order-2 text-[#8b8a91] text-[22px] pt-8 tracking-wide h-[14em]"
                style="font-family: var(--ff-bellefair)">

                <h2> THE TERMINOLOGY...</h2>

                <h3 
                    class="text-white text-[28px] pt-2 font-thin"
                        >{{ getData?.technology[currentIndex]?.name.toUpperCase() }}
                </h3>

                <p
                    class="text-white pt-4 text-[18px] font-thin w-[91%] max-w-[25em] tracking-wide"
                    style="font-family: var(--ff-barlow-condensed)"
                        >{{ getData?.technology[currentIndex]?.description }}
                </p>
            </div>
        </div>
    </div>

    <div 
        v-else 
        class="flex items-center justify-center h-64">
        <v-progress-circular 
            indeterminate 
            color="amber" 
        />
    </div>
</template>


<script setup>
    defineOptions({ name: 'TechnologyCarousel' });
    import { FetchAPI } from '@/Composables/FetchAPI';
    import { ref, onMounted } from 'vue';

    const { getData, getRequest } = FetchAPI();
    const currentIndex = ref(0);

    onMounted(async () => 
    {
        getData.value = await getRequest('/technology');
    });

    const updateCurrentIndex = (index) => 
    {
       currentIndex.value = index;
    };
</script>