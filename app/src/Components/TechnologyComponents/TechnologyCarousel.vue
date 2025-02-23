<template>
    <div 
        v-if="getData?.technology" 
        class="absolute w-full pt-20 flex flex-col items-center justify-center">
    
        <div 
            class="relative w-full flex flex-col min-[768px]:flex-row items-center justify-center h-[75vh]">
            
            <v-carousel
                :show-arrows="false"
                color="white"
                :cycle="false"
                interval="3500"
                hide-delimiter-background
                hide-delimiters
                height="100%" 
                @change="updateCurrentIndex"
                v-model="currentIndex"
                class="min-[768px]:order-3">
    
                <v-carousel-item 
                    v-for="(tech, index) in getData?.technology"
                    :key="index">
       
                    <div class="flex items-center justify-center h-full w-full">
                        <img 
                            :src="getImageSrc(index, tech)"
                            :draggable="false"
                            :alt="`${tech?.name}'s image`"
                            :class="[ 
                                'h-[100%] w-[100%] object-cover', 
                                'min-[1400px]:h-full min-[1400px]:w-full min-[768px]:object-scale-down',
                                index === 0 ? 'max-[616px]:object-[0%_100%] min-[616px]:object-[0%_-200px] min-[768px]:object-[50%_50%]' : '',
                                index === 1 ? 'max-[616px]:object-[50%_50%] min-[616px]:object-[0%_80%]' : '',
                                index === 2 ? 'min-[768px]:object-[50%_50%]' : ''
                            ]"
                        />
                    </div>
                </v-carousel-item>

                <template v-slot:placeholder>
                    <div class="flex items-center justify-center fill-height">
                        <v-progress-circular
                            color="amber"
                            indeterminate
                            aria-label="Loading destination image"
                        ></v-progress-circular>
                    </div>
                </template>
            </v-carousel>
            
            <div class="flex justify-center items-center min-[768px]:ml-[12%] min-[768px]:mr-[5%]
                min-[1920px]:ml-[8%] min-[768px]:order-1">
                <div class="flex min-[768px]:space-x-0 space-x-5 min-[768px]:flex-col">
                    <button
                        v-for="(tech, index) in getData?.technology"
                        :key="index"
                        style="font-family: var(--ff-bellefair)"
                        class="min-[768px]:w-[3.5em] min-[768px]:h-[3.5em] w-10 h-10 rounded-full flex items-center justify-center mt-10"
                        :class="[ 
                            currentIndex === index 
                            ? 'bg-white text-black' 
                            : 'bg-transparent text-white border-[1px] border-solid border-white '
                        ]"
                        @click="currentIndex = index"
                    >{{ index + 1 }}</button>
                </div>
            </div>

            <div 
                class="flex flex-col justify-center items-center 
                    min-[768px]:w-[150%] min-[1900px]:w-[39%] min-[768px]:order-2 text-[#8b8a91]
                    text-[22px] pt-8 tracking-wide h-auto min-[768px]:items-start"
                style="font-family: var(--ff-bellefair)">

                <h2 class="text-center min-[768px]:text-left">
                    THE TERMINOLOGY...
                </h2>

                <h3 class="text-center min-[768px]:text-left text-white 
                    text-[28px] pt-2 font-thin min-[768px]:text-[40px]">
                    {{ getData?.technology[currentIndex]?.name.toUpperCase() }}
                </h3>

                <p class="max-[768px]:text-center min-[768px]:text-left pt-4 text-[18px] font-thin w-[91%] 
                    max-w-[25em] tracking-wide text-[#d0d6f9] "
                    style="font-family: var(--ff-barlow-condensed)">
                    {{ getData?.technology[currentIndex]?.description }}
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

    onMounted(async () => {
        getData.value = await getRequest('/technology');
    });

    const updateCurrentIndex = (index) => {
        currentIndex.value = index;
    };

    const getImageSrc = (index, tech) => {
        if (index === 2 && window.innerWidth >= 768) {
            return tech?.images?.portrait;
        }
        return index <= 1 ? tech?.images?.portrait : tech?.images?.landscape;
    };
</script>
