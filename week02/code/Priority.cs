public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1: 
        // Scenario: Enqueue items and then dequeue them in the correct order based on priority
        // Expected result:  [Zebra (Pri:3), Ant (Pri:1), Lion (Pri:2), Tiger (Pri:1), Elephant (Pri:3)]
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Zebra", 3);
        priorityQueue.Enqueue("Ant", 1);
        priorityQueue.Enqueue("Lion", 2);
        priorityQueue.Enqueue("Tiger", 1);
        priorityQueue.Enqueue("Elephant", 3);

        Console.WriteLine($"Queue: {priorityQueue}");

        // Dequeue the items with the highest priority (priority 3)
        // Expected result: Dequeued: Zebra, Dequeued: Elephant
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");
        Console.WriteLine();
        Console.WriteLine($"Queue: {priorityQueue}");

        // Dequeue the items with the highest priority (priority 2)
        // Expected result: Dequeued: Lion
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");
        Console.WriteLine();
        Console.WriteLine($"Queue: {priorityQueue}");

        // Dequeue the items with the highest priority (priority 1)
        // Expected result: Dequeued: Ant, Dequeued: Tiger
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");

        Console.WriteLine($"Queue: {priorityQueue}");

        //Defect(s) Found: Dequeue function was not correctly removing the item with the highest priority when there are multiple items with the same priority

        Console.WriteLine();
        Console.WriteLine();

        // Test 2: 
        //Expected Empty queue error message
        Console.WriteLine("Test 2");

        try
        {
            // Dequeue from an empty queue
            priorityQueue.Dequeue();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Dequeued: {ex.Message}");
        }

    }
}