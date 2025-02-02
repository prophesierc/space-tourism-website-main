<template>
    <div 
        v-if="getData?.technology" 
        class="absolute w-full pt-20 md:mt-20">
    
        <div 
            class="relative w-full">
            <v-carousel
                :show-arrows="false"
                color="white"
                :cycle="false"
                interval="3500"
                hide-delimiter-background
                hide-delimiters
                height="300"
                @change="updateCurrentIndex"
                v-model="currentIndex">

                <v-carousel-item 
                    v-for="(tech, index) in getData?.technology"
                    :key="index">
                    <div class="flex align-center justify-center flex-col h-[100%] w-[100%]">
                        <img 
                            :src="tech?.images?.landscape" 
                            :draggable="false"
                            :srcset="`
                                ${tech?.images?.portrait} 600w,
                                ${tech?.images?.landscape} 1200w
                            `"
                            sizes="(max-width: 600px) 100vw, 600px"
                            :alt="`${tech?.name}'s image`"
                            class="h-[75%] w-[100%] object-fill
                                min-[616px]:object-cover min-[616px]:object-[50%_5%]
                                min-[768px]:w-[100%] min-[768px]:h-[100%] min-[768px]:object-fill"
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

            <div class="flex justify-center items-center pt-5">
                <div class="flex space-x-5">
                    <button
                        v-for="(tech, index) in getData?.technology"
                        :key="index"
                        style="font-family: var(--ff-bellefair)"
                        class="w-10 h-10 rounded-full flex items-center justify-center mt-5"
                        :class="[
                            currentIndex === index 
                            ? 'bg-white text-black' 
                            : 'bg-transparent text-white border-[1px] border-solid border-white'
                        ]"
                        @click="currentIndex = index"
                            >{{ index + 1 }}
                    </button>
                </div>
            </div>

            <div 
                class="flex flex-col text-center justify-center align-center w-full text-[#8b8a91] text-[22px] pt-8 tracking-wide h-[14em]"
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
