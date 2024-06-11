private readonly object _lock1 = new object();
private readonly object _lock2 = new object();

// Prone to deadlock

void Method1()
{
    lock (_lock1)
    {
        lock (_lock2)
        {
            // Work with both resources
        }
    }
}


void Method2()
{
    lock (_lock2)
    {
        lock (_lock1)
        {
            // Work with both resources
        }
    }
}

// Correct way

void Method1()
{
    lock (_lock1)
    {

    }
    lock (_lock2)
    {

    }
}


void Method2
{
    lock (_lock2)
    {

    }
    lock (_lock1)
    {

    }
}