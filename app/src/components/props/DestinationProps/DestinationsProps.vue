<template>
  <div 
    id="destination__content__container" 
    class="flex flex-col absolute w-screen h-screen justify-center" 
    style="font-family: var(--ff-barlow-condensed);"
  >
    <div id="content__container" class="flex flex-col justify-center items-center w-auto h-[34rem]">
      <span class="flex text-[16px] tracking-widest text-[#d0d6f9]">
        <span class="font-bold pr-5 text-[#53555f]">01</span>
        <span>PICK YOUR DESTINATION</span>
      </span>    

      <div v-for="(destination, index) in postData" :key="index">
        <v-img
          v-if="index === props.index"
          :width="500"
          aspect-ratio="16/9"
          cover
          class="absolute"
          :src="destination.images.png" 
        ></v-img>
      </div>

    </div>
  </div>
</template>

<script setup>
  import { onMounted, ref } from 'vue';

  const props = defineProps({
      index: Number,
  });

  const postData = ref([]);

  const getPost = async () => 
{
    try 
    {
      const APIKey = import.meta.env.VITE_API_KEY; 
      const response = await fetch('https://prophesierc.site/api/SpaceData', 
      {
        method: 'GET',
        headers: 
        {
            'X-API-Key': APIKey
        }
      });

      if (!response.ok) 
      {
          throw new Error('Network response was not ok');
      }
      return await response.json();
    } 
    catch (error) 
    {
        console.error('Fetch error:', error);
        return [];
    }
};

  onMounted(async () => 
  {
    const data = await getPost();
    postData.value = data.destinations || []; 
  });
</script>