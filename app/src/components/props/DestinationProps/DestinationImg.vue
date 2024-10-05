<template>
  <div 
    class="absolute m-20" 
    v-for="(destination, index) in postData" 
    :key="index">
  
    <v-img
      v-if="index === props.index"
      :width="200"
      :src="destination.images.png" 
    >
      <template v-slot:placeholder>
        <div class="d-flex align-center justify-center fill-height">
          <v-progress-circular
            color="amber"
            indeterminate
          ></v-progress-circular>
        </div>
      </template>

  </v-img>
  </div>
</template>



<script setup>
  defineOptions({name: 'DestinationImg'})
  import { FetchAPI } from '@/Composables/FetchAPI';

  const props = defineProps(
  {
    index: Number,
  });

  const { postData } = FetchAPI(props.index);
</script>