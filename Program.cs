using System;

namespace DateComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("1. {0:MMMM} {0:dd}, {0:yyyy}", today);
            Console.WriteLine("2. {0:yyyy}.{0:MM}.{0:dd}", today);
            Console.WriteLine("3. Day {0:dd} of {0:MMMM}, {0:yyyy}", today);
            Console.WriteLine("4. Year:{0:yyyy},Month:{0:MM},Day:{0:dd}", today);
            Console.WriteLine("5. {0:dddd}", today);
            Console.WriteLine("6. {0:hh}:{0:mm} {0:tt}", today);
            Console.WriteLine("7. h:{0:hh},m:{0:mm},s:{0:ss}", today);
            Console.WriteLine("8. {0:yyyy}.{0:MM}.{0:dd}.{0:hh}.{0:mm}.{0:ss}", today);
        }
    }
}
