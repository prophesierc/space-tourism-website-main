<template>
  <div 
    class="absolute flex flex-col items-center pb-10 min-h-96 h-full" 
    v-for="(destination, index) in postData" 
    :key="index">
    <keep-alive>
      <v-img
        v-if="index === props.index"
        :width="200"
        :src="destination.images.png" 
        class="mb-10"
        alt="Destination Image"
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
      </v-img>
    </keep-alive>

      <div
        class="text-white relative flex flex-col items-center h-0"
        v-if="index === props.index">
        
        <h2
          class="text-[60px] tracking-tight"
          style="font-family: var(--ff-bellefair)"
            >{{destination.name.toUpperCase()}}
        </h2>
        <p 
          class="text-[17px] text-center mx-8 tracking-tight font-[300] pr-5 text-[#d0d6f9]"
            >{{destination.description}}
            <span><hr class="h-px my-5 border-0 dark:bg-gray-700"></span>
          </p>

          <h3 class="text-center"
          style="font-family: var(--ff-bellefair)">
            <span 
              class="text-[#d0d6f9] text-[12px] tracking-wide font-thin"
                >AVG. DISTANCE
            </span>
            <p 
              class="text-white text-[28px] tracking-wide pb-5"
                >{{destination.distance.toUpperCase()}}
            </p>
          </h3>

          <h4 class="text-center"
          style="font-family: var(--ff-bellefair)">
            <span 
              class="text-[#d0d6f9] text-[12px] tracking-wide font-thin"
                >EST. TRAVEL TIME
            </span>
            <p 
              class="text-white text-[28px] tracking-wide"
                >{{destination.travel.toUpperCase()}}
            </p>
          </h4>
      </div>
  </div>
</template>

<script setup>
  defineOptions({name: 'DestinationImg'})
  import { FetchAPI } from '@/Composables/FetchAPI';
  const { postData } = FetchAPI();
  const props = defineProps(
  {
    index: Number,
  });
</script>