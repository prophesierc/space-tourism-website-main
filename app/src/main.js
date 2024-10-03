import { createApp, h } from 'vue';
import App from '@/App.vue';
import '@/style.css';
import VueLazyload from 'vue-lazyload';
import { createWebHistory, createRouter } from 'vue-router';

// Vuetify
import { createVuetify } from 'vuetify';
import 'vuetify/styles'; // Ensure you include the Vuetify styles
import * as components from 'vuetify/components';
import * as directives from 'vuetify/directives';

// Keep Alive assets
import ImageHandler from '@/components/props/ImageHandler.vue';
import NavBar from '@/components/NavBar.vue';

// routes
const routes = [
  { path: '/', component: App },
  { path: '/destination', component: () => import('@/routes/Destination.vue') },
  { path: '/images', component: ImageHandler, meta: { KeepAlive: true } },
  { path: '/icons', component: NavBar, meta: { KeepAlive: true } },
];

// router
const router = createRouter({
  history: createWebHistory('/space-tourism-website-main/'),
  routes,
});

const vuetify = createVuetify({ components, directives });
const app = createApp(App);

// Vue Lazyload and Vuetify Spinner
app.use(VueLazyload, 
  {
  preLoad: 1.3,
  loading: h(components.VProgressCircular, 
    {
      color: 'amber',
      indeterminate: true,
    }),
  attempt: 1,
  });

app.use(vuetify);
app.use(router);
app.mount('#app');
