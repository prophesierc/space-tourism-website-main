import { createApp } from 'vue';
import App from '@/App.vue';
import '@/style.css';
import VueLazyload from 'vue-lazyload';
import router from '@/Router/index.js'

// Vuetify
import { createVuetify } from 'vuetify';
import 'vuetify/styles';
import * as components from 'vuetify/components';
import * as directives from 'vuetify/directives';

const vuetify = createVuetify({ components, directives });
const app = createApp(App);

// Vue Lazyload
app.use(VueLazyload, {
  preLoad: 1,
  attempt: 1,
});

app.use(vuetify);
app.use(router);
app.mount('#app');