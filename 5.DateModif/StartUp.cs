namespace DateModifier
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string firstdate = Console.ReadLine();
            string seconddate = Console.ReadLine();

            Console.WriteLine(DateModifier.Diff(firstdate, seconddate));
        }
    }
}