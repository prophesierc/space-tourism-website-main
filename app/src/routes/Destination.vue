<template>
    <DestinationContentComponent />
    <router-view v-slot="{ Component }">
      <keep-alive>
        <component :is="Component" />
      </keep-alive>
    </router-view>
</template>

<script setup>
  defineOptions({ name: 'Destination' });
  import DestinationContentComponent from '@/Components/components/DestinationComponents/DestinationContentComponent.vue';
</script>
