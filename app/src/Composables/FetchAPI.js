import { onMounted, ref } from 'vue';
export function FetchAPI()
{
    const postData = ref([]);
    const getPost = async () => 
    {
        try 
        {
            const APIKey = import.meta.env.VITE_API_KEY; 
            const response = await fetch('https://prophesierc.site/api/SpaceData/proxy/data', 
            {
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

    onMounted(async () => 
    {
        const data = await getPost();
        postData.value = data || []; 
    });
    return { postData };
}