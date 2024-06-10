
async Task<int> GetUrlContentLengthAsync()
{
    var client = new HttpClient();

    Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com/dotnet");

    DoIndependentWork();

    string contents = await getStringTask;

    return contents.Length;
}

async void DoIndependentWork()
{
    Console.WriteLine("Impendent work!");
}

var result = await GetUrlContentLengthAsync();
Console.WriteLine(result);