<template>
  <div 
  class="absolute m-20"
    v-for="(destination, index) in postData" :key="index">
    <v-img
      v-if="index === props.index"
      :width="200"
      :src="destination.images.png" 
    ></v-img>
  </div>
</template>

<script setup>
  import { onMounted, ref } from 'vue';
  defineOptions({ name: 'FetchDestinationImg' });
  
  const props = defineProps(
  {
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