<template>
    <div 
      id="destination__content__container" 
      class="flex flex-col absolute w-screen h-screen justify-center" 
      style="font-family: var(--ff-barlow-condensed);">
      
      <div id="content__container" class="flex justify-center w-auto h-[34rem]">
        <span class="flex text-[16px] tracking-widest text-[#d0d6f9]">
          <span class="font-bold pr-5 text-[#53555f]">01</span>
          <span>PICK YOUR DESTINATION</span>
        </span>
  
        <img 
          v-for="post in postData" 
          :src="post[index].images.png" 
          class="w-auto h-auto absolute"
        />
      </div>
    </div>
</template>
  
<script setup>
    import { onMounted, ref } from 'vue';

    const props = defineProps(
    {
        index: Number, 
    });

    const postData = ref([]);
    const getPost = async () => 
    {
        try 
        {
            const response = await fetch('http://localhost:3000/destinations');
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

    onMounted( async () => 
    {
    const data = await getPost();
    postData.value = data.destinations;
    });
</script>
  