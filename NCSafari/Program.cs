namespace NCSafari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Animals!");

            Tiger fluffy = new Tiger(70.5f);
            Penguin penny = new Penguin(21);

            fluffy.Move();
            penny.Move();

            fluffy.MakeSound();
            penny.MakeSound();
        }
    }
}
