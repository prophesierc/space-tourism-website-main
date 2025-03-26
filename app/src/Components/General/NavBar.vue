<template>
  <v-container
    class="flex absolute top-0 left-0 min-w-[100vw]" 
    style="font-family: var(--ff-barlow-condensed);">

    <v-row align="center" justify="space-between">
      
      <v-col cols="auto">

        <!-- Logo  -->
        <img 
          v-lazy="Logo"
          alt="Website Logo" 
          :draggable="false"
          :class="{'w-full h-full': resolutions.isMobile, 
            'w-full h-full mb-8': !resolutions.isMobile }" 
          class="min-[768px]:mt-10 min-[768px]:pl-10"
          aria-label="Company logo"
        />
      </v-col>
      
      <v-col cols="auto" class="flex flex-row justify-end "> 

        <!-- mobile -->
        <img 
          v-if="resolutions.isMobile"
          v-lazy="OpenDrawer"
          :draggable="false"
          @click="drawer = !drawer" 
          alt="Open Menu" 
          class='w-full h-full pr-3'
          aria-label="Open the main menu"
        />

        <!-- tablet / Desktop -->
        <v-list 
          :ripple="false"
          v-if="!resolutions.isMobile"
          :class="[ 
            'flex flex-row text-white bottom-4 left-4 h-20 max-w-[600px] justify-end overflow-hidden min-[768px]:mt-10',
            resolutions.isDesktop 
              ? 'bg-transparent backdrop-blur-md backdrop-opacity-100 border pr-10 pl-15' 
              : 'custom-bg'
          ]">

          <v-list-item 
            to="/" 
            :class="{ 'active-class': activeIndex === 0 }"
            :active=false
            aria-label="Navigate to Home page">
            <template v-slot:default>
              <p class="font-light">HOME</p>
            </template>
          </v-list-item>

          <v-list-item 
            to="/destination"
            :class="{ 'active-class': activeIndex === 1 }"
            :active=false
            aria-label="Navigate to Destination page">
            <template v-slot:prepend>
              <p class="font-bold tracking-widest pr-2">01</p>
            </template>
            <template v-slot:default>
              <p class="tracking-widest font-light">DESTINATION</p>
            </template>
          </v-list-item>
        
          <v-list-item 
            to="/crew" 
            :class="{ 'active-class': activeIndex === 2 }"
            :active=false
            aria-label="Navigate to Crew page">
            <template v-slot:prepend>
              <p class="font-bold tracking-widest pr-2">02</p>
            </template>
            <template v-slot:default>
              <p class="tracking-widest font-light">CREW</p>
            </template>
          </v-list-item>
        
          <v-list-item 
            to="/technology" 
            :class="{ 'active-class': activeIndex === 3 }"
            :active=false
            class="sm:mr-5"
            aria-label="Navigate to Technology page">
            <template v-slot:prepend>
              <p class="font-bold tracking-widest pr-2">03</p>
            </template>
            <template v-slot:default>
              <p class="font-light">TECHNOLOGY</p>
            </template>
          </v-list-item>
  
        </v-list>

        <!-- Desktop HR WIP -->
        <hr 
          v-if="resolutions.isDesktop"
          class="w-[22%] min-[850px]:w-[27%] min-[1000px]:w-[37%] min-[1200px]:w-[44%] min-[1500px]:w-[52%] min-[1920px]:w-[58%]
          absolute top-[48px] left-[15%] h-px my-8 border-0 bg-gray-700">

      </v-col>
    </v-row>

    <!-- mobile drawer -->
    <v-navigation-drawer 
      v-if="resolutions.isMobile"
      v-model="drawer" 
      temporary 
      app 
      :location="$vuetify.display.mobile ? 'right' : undefined"
      class="bg-transparent backdrop-blur-sm"
      aria-label="Main navigation drawer"
      >
      <v-list-item>
        <img 
          v-lazy="CloseDrawer"
          class="absolute right-4 m-3 w-5 h-5" 
          alt="Close Menu" 
          @click="drawer = !drawer"
          aria-label="Close the main menu"
        />
      </v-list-item>

      <v-list density="default" width="100%" 
        ripple 
        rounded 
        nav 
        class="mt-20 text-white flex flex-column pl-8">
        <v-list-item value="home" 
          to="/"
          aria-label="Navigate to Home page">
          <template v-slot:prepend>
            <p class="pr-3 font-bold text-base tracking-widest ">00</p>
          </template>
          <template v-slot:default>
            <p class="ml-1 tracking-widest text-base font-thin">HOME</p>
          </template>
        </v-list-item>

        <v-list-item value="destination" 
          to="/destination"
          aria-label="Navigate to Destination page">
          <template v-slot:prepend>
            <p class="pr-3 font-bold text-base tracking-widest">01</p>
          </template>
          <template v-slot:default>
            <p class="ml-1 tracking-widest text-lg font-thin">DESTINATION</p>
          </template>
        </v-list-item>

        <v-list-item value="crew" 
          to="/crew"
          aria-label="Navigate to Crew page">
          <template v-slot:prepend>
            <p class="pr-3 font-bold text-base tracking-widest">02</p>
          </template>
          <template v-slot:default>
            <p class="ml-1 tracking-widest text-lg font-thin">CREW</p>
          </template>
        </v-list-item>

        <v-list-item value="technology" 
          to="/technology"
          aria-label="Navigate to Technology page">
          <template v-slot:prepend>
            <p class="pr-3 font-bold text-base tracking-widest">03</p>
          </template>
          <template v-slot:default>
            <p class="ml-1 tracking-widest text-lg font-thin">TECHNOLOGY</p>
          </template>
        </v-list-item>

      </v-list>
    </v-navigation-drawer>
  </v-container> 
</template>

<script setup>
  defineOptions({ name: 'NavBar' });
  import Logo from '/assets/shared/logo.svg';
  import OpenDrawer from '/assets/shared/icon-hamburger.svg';
  import CloseDrawer from '/assets/shared/icon-close.svg';
  import { ref, computed, onMounted, onUnmounted } from 'vue';

  const drawer = ref(false);
  const windowWidth = ref(window.innerWidth);

  const props = defineProps(
    {
      activeIndex: 
      {
        type: Number,
        required: true,
      },
  });

  const resolutions = computed(() => 
  ({
    isDesktop: windowWidth.value >= 768,
    isTablet: windowWidth.value < 768 && windowWidth.value > 615,
    isMobile: windowWidth.value <= 615,
  }));

  const resizeHandler = () => 
  {
    windowWidth.value = window.innerWidth;
  };

  onMounted(() => 
  {
    window.addEventListener('resize', resizeHandler);
  });

  onUnmounted(() => 
  {
    window.removeEventListener('resize', resizeHandler);
  });
</script>

<style scoped>
  .active-class {
    border-bottom: 3px solid white;
    padding-bottom: 8px;
    height: 70px;    
  }

  .custom-bg {
    background-color: #252831 !important;
  }
</style>
