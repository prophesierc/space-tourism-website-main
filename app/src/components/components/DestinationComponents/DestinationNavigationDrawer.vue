<template>
    <v-list 
        nav 
        bg-color="transparent">
      <v-container>
        <v-row 
            justify="center">
          <v-col>

            <v-btn-toggle
                class="text-white"
                v-model="selectedButton"
                selected-class="active-btn"
                mandatory>

                <v-btn
                    variant="plain"
                    :ripple="false"
                    value="moon"
                    ><span 
                    class="btn-text" 
                    >MOON</span
                ></v-btn>

                <v-btn
                    variant="plain"
                    :ripple="false"
                    value="mars"
                    ><span 
                    class="btn-text"
                    to="@Components/props/DestinationProps/Destinations/Mars.vue"
                    >MARS</span
                ></v-btn>
                
                <v-btn
                    variant="plain"
                    :ripple="false"
                    value="europa"
                    ><span 
                    class="btn-text"
                    >EUROPA</span
                ></v-btn>

                <v-btn
                    variant="plain"
                    :ripple="false"
                    value="titan"
                    ><span 
                    class="btn-text"
                    >TITAN</span
                ></v-btn>

            </v-btn-toggle>

          </v-col>
        </v-row>
      </v-container>
    </v-list>
  </template>
  
  <script setup>
  defineOptions({ name: 'DestinationNavigationDrawer' });

  import { ref } from 'vue';
  const selectedButton = ref('moon');
  // defaults to moon
  </script>
  
  <style scoped>
  .active-btn .btn-text {
    border-bottom: 4px solid white;
  }
  
  .btn-text {
    padding-bottom: 12px; 
  }
  </style>
  