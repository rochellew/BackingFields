namespace BackingFields
{
    public class Program
    {
        static void Main(string[] args)
        {
            TimePeriod t = new TimePeriod();

            // the property assignment causes the 'set' accessor to be called
            t.Hours = 24;

            // Retrieving the property value causes the 'get' accessor to be called
            Console.WriteLine($"Time in hours: {t.Hours}");

            Console.WriteLine($"Time in seconds: {t.Seconds}");

            var person = new Person("Jack", "Ramsey");
            Console.WriteLine(person.Name);
        }
    }
}