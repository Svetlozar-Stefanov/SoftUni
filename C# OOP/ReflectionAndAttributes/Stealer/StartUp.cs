using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        Spy spy = new Spy();

        Console.Write(spy.CollectGettersAndSetters("Hacker"));
    }
}

