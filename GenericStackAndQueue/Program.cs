using GenericStackAndQueue;

Person p1Out = new StudentOut("Alice", 20);
Person p2Out = new StudentOut("Bob", 22);
Person p3Out = new StudentOut("Charlie", 18);
Person p4Out = new StudentOut("Danny", 24);

Person p1Home = new StudentHome(600000, "Eric",20);
Person p2Home = new StudentHome(400000, "Frank", 22);
Person p3Home = new StudentHome(300000, "Greg", 18);
Person p4Home = new StudentHome(600000, "Henry", 24);

//MyStackLinkedList<Person> stackCollection = new MyStackLinkedList<Person>(7);
MyStackArray<Person> stackCollection = new MyStackArray<Person>(7);

//Push method
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
Console.WriteLine($"Using Peek method: {stackCollection.Peek()}\n");


//Pop method
try {
    for (int i = 0; i < 8; i++) {
        Console.WriteLine($"This item was removed: {stackCollection.Pop()}\n");
    }
}
catch (MyStackIsEmptyException eex) {
    Console.WriteLine(eex + "\n");
}

Console.ReadKey();