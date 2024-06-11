using System.Diagnostics;

// Synchronous
TimeSpan syncTimeTaken = MeasureTime(() =>
{
    SyncUtil.SimulateLongRunningTask();
    SyncUtil.SimulateLongRunningTask();
    SyncUtil.SimulateLongRunningTask();
});
Console.WriteLine($"Sync time taken: {syncTimeTaken.TotalSeconds} seconds");

// Asynchronous
TimeSpan asyncTimeTaken = MeasureTime(async () =>
{
    await getAsync(1);
    await getAsync(2);
    await getAsync(3);
});
Console.WriteLine($"Async time taken: {asyncTimeTaken.TotalSeconds} seconds");

// Edge case: Async method waiting together
TimeSpan edgeCaseTimeTaken = MeasureTime(async () =>
{
    var result1 = await getAsync(1);
    var result2 = await getAsync(result1);
    var result3 = await getAsync(result2);
});

Console.WriteLine($"EdgeCase time taken: {edgeCaseTimeTaken.TotalSeconds} seconds");


static async Task<int> getAsync(int input)
{
    await Task.Delay(2000); // waits for 2 seconds
    return input;
}

/* Util functions */
static TimeSpan MeasureTime(Action action)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    stopwatch.Start();
    action();
    stopwatch.Stop();

    return stopwatch.Elapsed;
}

static class SyncUtil
{
    public static void SimulateLongRunningTask()
    {
        Thread.Sleep(2000); // waits for 2 seconds
    }
}