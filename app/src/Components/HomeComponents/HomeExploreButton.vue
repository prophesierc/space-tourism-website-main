<template>
    <v-container class="flex h-full mt-auto">
      <v-row align="center" justify="center" class="flex h-full mt-auto">
        <v-col cols="auto" class="flex flex-row h-80 items-end">
          <v-btn 
            class="-mb-10"
            icon=''
            size="144" 
            text="EXPLORE"
            style="font-family: var(--ff-bellefair);"
            :loading="loading" 
            @click="startLoading"
          >
            
            <template v-slot:loader>
              <v-progress-circular
                color="amber"
                size=144
                indeterminate
              ></v-progress-circular>
            </template>

          </v-btn>
        </v-col>
      </v-row>
    </v-container>
  </template>
  
  <script setup>
  defineOptions({ name: 'HomeExploreButton' });
  import { ref } from 'vue';
  import { useRouter } from 'vue-router';
  
  const router = useRouter();
  const loading = ref(false);

  const startLoading = async () => 
  {
    loading.value = true;
    await router.push('/destination'); 
    loading.value = false;
  };
  </script>
  