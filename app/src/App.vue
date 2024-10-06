<template>
    <HomeContent />
      <router-view v-slot="{ Component }">
        <keep-alive>
          <component :is="Component" />
        </keep-alive>
      </router-view>
</template>

<script setup>
  defineOptions({ name: 'App' });
  import HomeContent from '@/Components/components/HomeComponents/HomeContent.vue';
</script>
