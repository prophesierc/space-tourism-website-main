import App from '@/App.vue'
import { createApp } from 'vue'
import '@/style.css'

//VueRouter
import { createMemoryHistory, createRouter } from 'vue-router'
import App from '@/App.vue'
import Destination from '@/routes/Destination'

const routes = [
  { path: '@/', component: App },
  { path: '@/routes/Destination', component: Destination },
]

const router = createRouter({
  history: createMemoryHistory(),
  routes,
})

// Vuetify
import 'vuetify/styles'
import { createVuetify } from 'vuetify'

// Components
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'

const vuetify = createVuetify({
  components,
  directives,
})

createApp(App).use(vuetify).use(router).mount('#app')
