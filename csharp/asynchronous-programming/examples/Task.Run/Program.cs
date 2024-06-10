async Task PerformTaskAsync()
{
    Console.WriteLine("Start of async method");

    // The `Task.Run` method is used to run CPU-bound tasks on a background thread
    // Using Task.Run to run a synchronous method asynchronously
    await Task.Run(() => PerformSynchronousTask());

    Console.WriteLine("End of async method");
}

static async void PerformSynchronousTask()
{
    Console.WriteLine("Executing synchronous task.");
}

await PerformTaskAsync();