async Task<int> GetDataAsyncDeadlock()
{
    var data = Task.Run(() =>
    {
        Thread.Sleep(1000);
        return 42;
    });

    return data.Result; // Blocking call, can lead to deadlock
}


async Task<int> GetDataAsync()
{
    var data = Task.Run(() =>
    {
        Thread.Sleep(1000);
        return 42;
    });

    return await data; // Properly awaits the task
}