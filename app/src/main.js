import { createApp } from 'vue';
import App from '@/App.vue';
import '@/style.css';
import VueLazyload from 'vue-lazyload';
import { createWebHistory, createRouter } from 'vue-router';

// Vuetify
import { createVuetify } from 'vuetify';
import 'vuetify/styles';
import * as components from 'vuetify/components';
import * as directives from 'vuetify/directives';

// routes
const routes = [
  { path: '/', component: App },
  { path: '/destination', component: () => import('@/routes/Destination.vue') },

  // Keep Alive assets
  { path: '/images', 
      component: () => 
        import('@/components/props/ImageHandlerProp/ImageHandler.vue'), 
      meta: { KeepAlive: true } 
  },
  { path: '/icons', 
      component: () => 
        import('@/components/components/NavBarComponent/NavBar.vue'), 
      meta: { KeepAlive: true } 
  },
];

// router
const router = createRouter(
{
  history: createWebHistory('/space-tourism-website-main/'),
  routes,
});

const vuetify = createVuetify({ components, directives });
const app = createApp(App);

// Vue Lazyload
app.use(VueLazyload, 
{
  preLoad: 1,
  attempt: 1,
});

app.use(vuetify);
app.use(router);
app.mount('#app');
