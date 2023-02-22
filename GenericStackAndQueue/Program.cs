using GenericStackAndQueue;
#region Initializers
Person p1Out = new StudentOut("Alice", 20);
Person p2Out = new StudentOut("Bob", 22);
Person p3Out = new StudentOut("Charlie", 18);
Person p4Out = new StudentOut("Danny", 24);

Person p1Home = new StudentHome(600000, "Eric",20);
Person p2Home = new StudentHome(400000, "Frank", 22);
Person p3Home = new StudentHome(300000, "Greg", 18);
Person p4Home = new StudentHome(600000, "Henry", 24);
#endregion

#region Stack Collection
Console.WriteLine("\n-----Beginning of Stack-----\n\n");
//MyStackLinkedList<Person> stackCollection = new MyStackLinkedList<Person>(7);
MyStackArray<Person> stackCollection = new MyStackArray<Person>(7);


//Push method
Console.WriteLine("---Push Method---\n");
try {
    stackCollection.Push(p1Out);
    stackCollection.Push(p2Out);
    stackCollection.Push(p3Out);
    stackCollection.Push(p4Out);

    stackCollection.Push(p1Home);
    stackCollection.Push(p2Home);
    stackCollection.Push(p3Home);
    stackCollection.Push(p4Home);
}
catch (MyStackIsFullException fex) {
    Console.WriteLine(fex + "\n");
}


//Peek method
Console.WriteLine("---Peek Method---\n");
Console.WriteLine($"Using Peek method: {stackCollection.Peek()}\n");


//Pop method
Console.WriteLine("---Pop Method---\n");
try {
    for (int i = 0; i < 8; i++) {
        Console.WriteLine($"This item was removed from the Stack: {stackCollection.Pop()}\n");
    }
}
catch (MyStackIsEmptyException eex) {
    Console.WriteLine(eex + "\n");
}
#endregion

#region Queue Collection
//-----------------------------------------------------------------------------------
Console.WriteLine("\n-----Beginning of Queue-----\n\n");


MyQueueLinkedList<Person> queueCollection = new MyQueueLinkedList<Person>(7);
//MyQueueArray<Person> queueCollection = new MyQueueArray<Person>(7);


//Enqueue method
Console.WriteLine("---Enqueue Method---\n");
try
{
    queueCollection.Enqueue(p1Out);
    queueCollection.Enqueue(p2Out);
    queueCollection.Enqueue(p3Out);
    queueCollection.Enqueue(p4Out);

    queueCollection.Enqueue(p1Home);
    queueCollection.Enqueue(p2Home);
    queueCollection.Enqueue(p3Home);
    queueCollection.Enqueue(p4Home);
}
catch (MyQueueIsFullException fex) {
    Console.WriteLine(fex + "\n");
}


//Dequeue method
Console.WriteLine("---Dequeue Method---\n");
try {
    //for (int i = 0; i < 8; i++) {
    //    Console.WriteLine($"This item was removed from the Queue: {queueCollection.Dequeue()}\n");
    //}
    Console.WriteLine("Dequeue 1: " + queueCollection.Dequeue());
    Console.WriteLine("Dequeue 2: " + queueCollection.Dequeue());
    Console.WriteLine("Dequeue 3: " + queueCollection.Dequeue());
    Console.WriteLine("Dequeue 4: " + queueCollection.Dequeue());
    Console.WriteLine("Dequeue 5: " + queueCollection.Dequeue());
    Console.WriteLine("Dequeue 6: " + queueCollection.Dequeue());
    Console.WriteLine("Dequeue 7: " + queueCollection.Dequeue());
    Console.WriteLine("Dequeue 8: " + queueCollection.Dequeue());
}
catch (MyQueueIsEmptyException eex) {
    Console.WriteLine(eex + "\n");
}
#endregion

Console.ReadKey();