// Concurrency with Async and Await 

async Task<string> GetDataFromAPIAsync()
{
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }
}