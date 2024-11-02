import { createWebHistory, createRouter } from 'vue-router';

// Define routes
const routes = 
[
    { 
      path: '/', 
      component: () => import('@/Routes/RoutingLayouts/HomeLayout.vue') 
    }, 
    { 
      path: '/destination', 
      component: () => import('@/Routes/RoutingLayouts/DestinationLayout.vue') 
    },
    { 
      path: '/crew', 
      component: () => import('@/Routes/RoutingLayouts/CrewLayout.vue') 
    },
    { 
      path: '/technology', 
      component: () => import('@/Routes/RoutingLayouts/TechnologyLayout.vue') 
    },
    {
      // error page 404
      path: '/:catchAll(.*)*',
      component: () => import('@/Routes/RoutingLayouts/ErrorPageLayout.vue')
    }
];

// Create the router
const router = createRouter(
{
    history: createWebHistory('/space-tourism-website-main/'),
    routes,
});

export default router