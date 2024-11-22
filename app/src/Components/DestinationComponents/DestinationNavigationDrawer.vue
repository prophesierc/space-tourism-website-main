<template>  
  <v-list nav bg-color="transparent" 
    class="absolute top-[14em] min-[525px]:top-[16em]">
    <v-container>
      <v-row>
        <v-col>
          <v-btn-toggle
            class="text-white"
            v-model="selectedButton"
            aria-label="Select a destination"
          >
            <v-btn 
              variant="plain" 
              :ripple="false"
              :class="{ 'disabled-button': selectedButton === 0 }"
              @click="selectButton(0)"
              aria-label="Select Moon">
              <span class="btn-text">MOON</span>
            </v-btn>

            <v-btn 
              variant="plain" 
              :ripple="false"
              :class="{ 'disabled-button': selectedButton === 1 }"
              @click="selectButton(1)"
              aria-label="Select Mars">
              <span class="btn-text">MARS</span>
            </v-btn>

            <v-btn 
              variant="plain" 
              :ripple="false"
              :class="{ 'disabled-button': selectedButton === 2 }"
              @click="selectButton(2)"
              aria-label="Select Europa">
              <span class="btn-text">EUROPA</span>
            </v-btn>

            <v-btn 
              variant="plain" 
              :ripple="false"
              :class="{ 'disabled-button': selectedButton === 3 }"
              @click="selectButton(3)"
              aria-label="Select Titan">
              <span class="btn-text">TITAN</span>
            </v-btn>
          </v-btn-toggle>
        </v-col>
      </v-row>
    </v-container>
  </v-list>
</template>

<script setup>
  import { ref, watch } from 'vue';

  const props = defineProps(
  {
    modelValue: Number,
  });

  const emit = defineEmits(['update:modelValue']); 
  const selectedButton = ref(props.modelValue); 

  const selectButton = (index) => 
  {
    selectedButton.value = index; 
  };

  watch(selectedButton, (updatedValue) => 
  {
    emit('update:modelValue', updatedValue);
  });

  watch(() => props.modelValue, (newVal) => 
  {
    selectedButton.value = newVal; 
  });
</script>

<style scoped>
  .btn-text {
    padding-bottom: 12px;
  }

  .disabled-button .btn-text {
    border-bottom: 4px solid white;
  }
</style>
