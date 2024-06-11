try
{
    string result = await FetchDataAsync("your.api");
    Console.WriteLine(result);
}
catch (HttpRequestException ex)
{
    // Handle HTTP request-specific exceptions
}
catch (ArgumentException ex)
{
    // Handle specfic argument exceptions
}
catch (Exception ex)
{
    // Handle other exceptions
}

static async Task<string> FetchDataAsync(string url)
{
    using (HttpClient client = new HttpClient())
    {
        // Simulate a possible exception scenario
        if (string.IsNullOrEmpty(url))
            throw new ArgumentException("URL can't be null or empty!");

        // Make an asynchronous HTTP GET request
        string result = await client.GetStringAsync(url);
        return result;
    }
}