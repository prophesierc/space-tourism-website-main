<template>
  <div 
    class="absolute flex flex-col items-center pb-10 min-h-96" 
    v-for="(destination, index) in postData" 
    :key="index">
    <keep-alive>
      <v-img
        v-if="index === props.index"
        :width="200"
        :src="destination.images.png" 
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
        class="text-white relative flex flex-col items-center h-0 bg-green"
        v-if="index === props.index">
        <h2
          class="text-[60px] tracking-tight"
          style="font-family: var(--ff-bellefair)"
            >{{destination.name.toUpperCase()}}
        </h2>
        <p 
          class="h-[0] text-center mx-8"
            >{{destination.description}}
        </p>
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