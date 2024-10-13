<template>

        <div v-if="postData['crew']" >
            <v-carousel 
                :show-arrows="false"
                color="amber"
                :cycle="false"
                interval="10000"
                class="absolute bg-transparent"
                >
                
                <v-carousel-item
                    :src="postData['crew'][0].images.png" 
                    :cover="false"
                    :alt="`${postData['crew'][0].name}'s image'`" 
                    class="bg-transparent"
                    >
    
                    <template v-slot:placeholder>
                        <div 
                            class="flex align-center justify-center items-center fill-height">
                            <v-progress-circular
                                color="amber"
                                indeterminate
                            ></v-progress-circular>
                        </div>
                    </template>
    
                </v-carousel-item>
              
                <v-carousel-item
                    :src="postData['crew'][1].images.png" 
                    :cover="false"
                    :alt="`${postData['crew'][1].name}'s image'`" 
                    >
    
                    <template v-slot:placeholder>
                        <div 
                            class="flex align-center justify-center items-center fill-height">
                            <v-progress-circular
                                color="amber"
                                indeterminate
                            ></v-progress-circular>
                        </div>
                    </template>
    
                </v-carousel-item>
    
                <v-carousel-item
                    :src="postData['crew'][2].images.png" 
                    :cover="false"
                    :alt="`${postData['crew'][2].name}'s image'`" 
                    >
    
                    <template v-slot:placeholder>
                        <div 
                            class="flex align-center justify-center items-center fill-height">
                            <v-progress-circular
                                color="amber"
                                indeterminate
                            ></v-progress-circular>
                        </div>
                    </template>
    
                </v-carousel-item>
    
            </v-carousel>
        </div>
      
</template>

<script setup>
    defineOptions({ name: 'CrewCarousel' })
    import { FetchAPI } from '@/Composables/FetchAPI';
    const { postData } = FetchAPI();
</script>
