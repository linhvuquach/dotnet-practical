
Task task1 = Task.Run(() => DoWork(1));
Task task2 = Task.Run(() => DoWork(2));
Task task3 = Task.Run(() => DoWork(3));

// Await thier completion
await Task.WhenAll(task1, task2, task3); // The `Task.WhenAll` method can be used to wait for multiple tasks to complete.

Console.WriteLine("All tasks completed.");

void DoWork(int taskNumber)
{
    // Simulate work
    Console.WriteLine($"Task {taskNumber} starting.");
    Task.Delay(2000).Wait(); // Synchronous wait to simulate work
    Console.WriteLine($"Task {taskNumber} completed.");
}