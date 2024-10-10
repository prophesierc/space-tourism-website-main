<template>
  <div 
    class="absolute m-20" 
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
          class="d-flex align-center justify-center fill-height">

          <v-progress-circular
            color="amber"
            indeterminate
          ></v-progress-circular>

        </div>
      </template>

      </v-img>
    </keep-alive>
  </div>
</template>

<script setup>
  import { FetchAPI } from '@/Composables/FetchAPI';
  defineOptions({name: 'DestinationImg'})

  const props = defineProps(
  {
    index: Number,
  });

  const { postData } = FetchAPI();
</script>