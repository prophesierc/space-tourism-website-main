<template>
  <div 
    class="absolute flex flex-col items-center pb-10 min-h-96 h-full" 
    v-if="getData && getData.destinations && getData.destinations.length > 0" 
  >
    <keep-alive>
      <v-img
        v-if="index >= 0 && index < getData.destinations.length" 
        :width="200"
        :src="getData.destinations[index].images.png" 
        class="mb-10"
        alt="Destination Image"
      >
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

    <div
      class="text-white relative flex flex-col items-center h-0"
      v-if="index >= 0 && index < getData.destinations.length"
    >
      <h2
        class="text-[60px] tracking-tight"
        style="font-family: var(--ff-bellefair)"
      >
        {{ getData.destinations[index].name.toUpperCase() }}
      </h2>
      <p 
        class="text-[16px] text-center mx-11 tracking-normal font-[300] text-[#d0d6f9]"
      >
        {{ getData.destinations[index].description }}
      </p>
    </div>
  </div>
</template>

<script setup>
import { defineProps } from 'vue';
const props = defineProps(
{
  getData: Object, 
  index: Number 
});
</script>
