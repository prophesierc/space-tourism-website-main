import { ref } from 'vue';

export function FetchAPI() 
{
    const getData = ref([]);

    const getRequest = async (endpoint) => 
    {
        try 
        {
            const response = await fetch(import.meta.env.BASE_URL + `data${endpoint}.json`, {
                method: 'GET',
              });   

            if (!response.ok) 
            {
                throw new Error('Network response was not ok');
            }
            return await response.json();
        } 
        catch (error) 
        {
            console.error('Fetch error:', error);
            return [];
        }
    };

    return { getData, getRequest }; 
}
