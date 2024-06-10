void ProcessData()
{
    var data = Enumerable.Range(1, 100).ToList();

    Parallel.ForEach(data, item =>
    {
        Console.WriteLine(item);
    });
}

ProcessData();