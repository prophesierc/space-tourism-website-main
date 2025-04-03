import { createWebHashHistory, createRouter } from 'vue-router';

const routes = [
    { 
      path: '/', component: () => import('@/Routes/RoutingLayouts/HomeLayout.vue') 
    }, 
    { 
      path: '/destination', component: () => import('@/Routes/RoutingLayouts/DestinationLayout.vue') 
    },
    { 
      path: '/crew', component: () => import('@/Routes/RoutingLayouts/CrewLayout.vue') 
    },
    { 
      path: '/technology', component: () => import('@/Routes/RoutingLayouts/TechnologyLayout.vue') 
    },
    { 
      path: '/:catchAll(.*)*', component: () => import('@/Routes/RoutingLayouts/ErrorPageLayout.vue') 
    }
];

const router = createRouter(
  {
    history: createWebHashHistory(),
    routes,
  }
);

export default router;