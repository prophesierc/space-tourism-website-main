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
            class="flex align-center justify-center fill-height">

            <v-progress-circular
              color="amber"
              indeterminate
            ></v-progress-circular>

          </div>
        </template>

      </v-img>
    </keep-alive>

      <div class="flex h-[20vh] flex-col">
        <p 
          v-if="index === props.index"
          class="flex text-white flex-col h-[0] items-center mt-auto"
          >{{destination.description}}
        </p>
        <!-- try to anchor to drawer for better relative positioning -->
      </div>

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