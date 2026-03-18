namespace NCSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Animals!");

            Tiger fluffy = new Tiger(70.5f);
            Penguin penny = new Penguin(21);

            //fluffy.Move();
            //penny.Move();
            fluffy.Hunt(); //prints "Tiger is hunting on land!"
            penny.Hunt(); //prints "Penguin is hunting in the water!"
            penny.Swim(); //prints "Penguin is swimming!"

            fluffy.MakeSound();
            penny.MakeSound();
        }
    }
}
