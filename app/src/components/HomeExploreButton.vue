<template>
    <v-container>
      <v-row align="center" justify="center">
        <v-col cols="auto">
          <v-btn 
            icon=""
            text="EXPLORE"
            size="144" 
            href="https://google.com"
            :loading="loading" 
            @click="startLoading">
            <template v-slot:loader>
              <v-progress-circular 
                :model-value="progress" 
                :size="144">
              </v-progress-circular>
            </template>
          </v-btn>
        </v-col>
      </v-row>
    </v-container>
  </template>
  
  <script setup>
  import { ref } from 'vue';
  const loading = ref(false);
  const progress = ref(0);
  
  const startLoading = () => 
  {
    loading.value = true;
    progress.value = 0;
  
    const interval = setInterval(() => 
    {
      if (progress.value < 100) 
      {
        progress.value += 10;
      } 
      else 
      {
        clearInterval(interval);
        loading.value = false; 
      }
    }, 200);
  };
  
  defineOptions({ name: 'HomeExploreButton' });
  </script>
  