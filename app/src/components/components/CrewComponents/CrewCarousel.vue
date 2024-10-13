<template>
    <div v-if="postData['crew']" class="mt-10 position-relative drop-shadow-[0_20px_40px_rgba(0,0,0,1)]">
        <v-carousel 
            :show-arrows="false"
            color="white"
            :cycle="false"
            interval="5000"
            :height="650"
            hide-delimiter-background
            hide-delimiters
            @change="updateCurrentIndex"
            v-model="currentIndex"
            

        >
            <v-carousel-item
                v-for="(crew, index) in postData['crew']"
                :key="index"
                :srcset="`${crew.images.png} 480w, ${crew.images.webp} 800w`"
                sizes="(max-width: 600px) 480px, 800px"
                :src="crew.images.png"
                :cover="false"
                :alt="`${crew.name}'s image`"
                position="0px 100%"
                max-width="290"
                min-height="650"
                >
                <div>
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
                        class="text-[16px] text-center tracking-wide font-[300] text-[#d0d6f9] pb-10 "
                        style="font-family: var(--ff-barlow-condensed)">
                        {{ crew.bio }}
                    </p>
                </div>

                <template v-slot:placeholder>
                    <div class="flex items-center justify-center fill-height">
                        <v-progress-circular color="amber" indeterminate></v-progress-circular>
                    </div>
                </template>
            </v-carousel-item>
        </v-carousel>

        <div class="custom-delim">
            <span
                v-for="(crew, index) in postData['crew']"
                :key="index"
                class="delim"
                :class="{ active: currentIndex === index }"
                @click="currentIndex = index"
            ></span>
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

<style scoped>

.custom-delim {
    position: absolute;
    bottom: 63%; 
    left: 50%;
    transform: translateX(-50%);
    display: flex; 
    gap: 16px; 
}

.delim {
    width: 12px;
    height: 12px; 
    background-color: rgba(255, 255, 255, 0.5);
    border-radius: 50%; 
}

.delim.active {
    background-color: white; 
}
</style>
