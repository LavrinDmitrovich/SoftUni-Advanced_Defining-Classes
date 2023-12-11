namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int Qty = int.Parse(Console.ReadLine());


            for (int i = 0; i < Qty; i++)

            {
                string[] personNameAge  = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = personNameAge[0];
                int age = int.Parse(personNameAge[1]);

                Person person = new Person();
                person.Name = name;
                person.Age = age;    

                family.AddMember(person);
            }

            Person oldest = family.GetOldestMember();

            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}