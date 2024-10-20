<template>
  <div 
    class="absolute flex flex-col items-center pb-10 min-h-96 h-full" 
    v-if="getData.destinations">

    <keep-alive>
      <v-img
        :key="getData.destinations[index]" 
        :width="200"
        :src="getData.destinations[index].images.png" 
        class="mb-10"
        alt="Destination Image">

        <template v-slot:placeholder>
          <div class="flex align-center justify-center items-center fill-height">
            <v-progress-circular
              color="amber"
              indeterminate
            ></v-progress-circular>
          </div>
        </template>
        
      </v-img>
    </keep-alive>

    <div class="text-white relative flex flex-col items-center h-0">
      <h2
        class="text-[60px] tracking-tight"
        style="font-family: var(--ff-bellefair)"
          >{{ getData.destinations[index].name.toUpperCase() }}
      </h2>
      <p 
        class="text-[16px] text-center mx-11 tracking-normal font-[300] text-[#d0d6f9]"
          >{{ getData.destinations[index].description }}
        <span>
          <hr class="h-px my-5 border-0 dark:bg-gray-700">
        </span>
      </p>

      <h3 class="text-center" style="font-family: var(--ff-bellefair)">
        <span 
          class="text-[#d0d6f9] text-[12px] tracking-wide font-thin"
            >AVG. DISTANCE
        </span>
        <p 
          class="text-white text-[28px] tracking-wide pb-5"
            >{{ getData.destinations[index].distance.toUpperCase() }}
        </p>
      </h3>

      <h4 class="text-center" style="font-family: var(--ff-bellefair)">
        <span 
          class="text-[#d0d6f9] text-[12px] tracking-wide font-thin"
            >EST. TRAVEL TIME
        </span>
        <p 
          class="text-white text-[28px] tracking-wide"
            >{{ getData.destinations[index].travel.toUpperCase() }}
        </p>
      </h4>
    </div>

  </div>
</template>

<script setup>
  import { onMounted } from 'vue';
  import { FetchAPI } from '@/Composables/FetchAPI';

  const { getData, getRequest } = FetchAPI();
  const props = defineProps(
  {
    index: Number,
  });

  onMounted(async () => 
  {
    getData.value = await getRequest('/destinations');
  });
</script>
