# Asynchronous Programming

If you have any I/O-bound needs (such as requesting data from a network, accesing a database, or reading and writing to a file system), you'll want utilize asynchornous programming. You could also have CPU-bound code, such as performming an expensive calculation, which is also a good scenario for wrting async code.

C# has a language-level asynchronous programming model, which allows for easily writing asynchronous code without having to juggle callbacks or conform to a library that supports asynchrony. It follows what is known as the [Task-based Asynchronous Pattern (TAP)](https://learn.microsoft.com/en-us/dotnet/standard/asynchronous-programming-patterns/task-based-asynchronous-pattern-tap).

## Overview of the asynchronous model

The core of async programming is the **Task** and **Task<T>** objects, which model asynchronous operations. They are supported by the **async** and **await** keywords. The model is fairly simple in most cases:

- For I/O-bound code, you await an operation that returns a Task or Task<T> inside of an async method.
- For CPU-bound code, you await an operation that is started on a background thread with the Task.Run method.

The **await** keyword is where the magic happens. It yields control to the caller of the method that performed await, and it ultimately allows a UI to be responsive or a service to be elastic.

## What happens under the covers

On the C# side of things, the compiler transforms your code into a state machine that keeps track of things like yielding execution when an **await** is reached and resuming execution when a background job has finished.

## Key pieces to understand

- Async code can be used for both **I/O-bound** and **CPU-bound** code, but differently for each scenario.
- Async code uses **Task<T>** and **Task**, which are constructs used to model work being done in the background.
- The async keyword turns a method into an async method, which allows you to use the await keyword in its body.
- When the **await** keyword is applied, it suspends the calling method and yields control back to its caller until the **awaited task** is complete.
- **await** can only be used inside an async method.

## What happens in an async method

![image](https://github.com/linhvuquach/dotnet-practical/assets/26388126/1ef3d801-551b-4883-adac-fe4416cbf019)

## References

- https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios
- https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model#BKMK_WhatHappensUnderstandinganAsyncMethod
- Use case: https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/
