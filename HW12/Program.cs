Queue<string> patints = new Queue<string> ();
string? tmp;
TimeSpan interval = new TimeSpan(0, 1, 0);
while (true)
{
    Console.WriteLine("Insert name of patint: ");
    tmp = Console.ReadLine ();
    patints.Enqueue(tmp);
    Console.WriteLine("The doctor is busy Wait a minute...");
    Thread.Sleep(interval);
    patints.Dequeue ();
}
