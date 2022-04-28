public class Test
{
    public int x = 13;

    public void TestMessage()
    {
        Console.WriteLine("This is just a demonstration");
    }
}

public static class Extension
{
    public static bool Passed(this Test t, int input)
    {
        return input >= t.x;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Test t = new();
        int input1 = 9;
        int input2 = 15;
        t.TestMessage();
        Console.WriteLine("Is " + input1 + " big enough? {0}", t.Passed(input1) ? "Yes" : "No");
        Console.WriteLine("Is " + input2 + " big enough? {0}", t.Passed(input2) ? "Yes" : "No");
    }
}