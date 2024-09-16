import App from '@/App.vue'
import { createApp } from 'vue'
import '@/style.css'

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

createApp(App).use(vuetify).mount('#app')
