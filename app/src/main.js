import { createApp } from 'vue';
import App from '@/App.vue';
import '@/style.css';

// VueRouter
import { createWebHistory, createRouter } from 'vue-router';
import Destination from '@/routes/Destination.vue';

const routes = [
  { path: '/', component: App }, 
  { path: '/destination', component: Destination },
];

const router = createRouter({
  history: createWebHistory('/space-tourism-website-main/'), 
  routes,
});

// Vuetify setup
const vuetify = createVuetify({ components, directives });
import 'vuetify/styles';
import { createVuetify } from 'vuetify';
import * as components from 'vuetify/components';
import * as directives from 'vuetify/directives';


createApp(App).use(vuetify).use(router).mount('#app');
