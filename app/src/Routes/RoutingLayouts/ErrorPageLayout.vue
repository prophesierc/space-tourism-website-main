<template>
    <v-card class="flex flex-col justify-center align-center h-screen">

        <v-empty-state
            image="https://vuetifyjs.b-cdn.net/docs/images/components/v-empty-state/astro-cat.svg"
            alt="404 cat logo"
            :draggable="false"
            headline="Whoops, 404"
            title="Page not found"
            text="The page you were looking for does not exist">
    
            <template v-slot:actions>
                <v-btn 
                    class="flex flex-col mt-10 mb-20"
                    color="#e976fc"
                    text="Go Back Home"
                    to="/"
                ></v-btn>
            </template>
            
        </v-empty-state>     

    </v-card>
</template>
  
<script setup>
    defineOptions({ name: 'ErrorPageLayout' });
</script>