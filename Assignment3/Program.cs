namespace Assignment3 
{
    class Program 
    {
        static void Main(string[] args)
        {
            dateFormatting();
            Console.WriteLine();
            piFormatting();
        }
        static void dateFormatting() 
        {
            DateTime dt = new DateTime(2019, 01, 22, 23, 01, 27);
            Console.WriteLine($"{dt,40:MMMM,dd,yyyy}");
            Console.WriteLine($"{dt:yyyy.MM.dd}");
            Console.WriteLine($"Day {dt:dd} of {dt:MMMM, yyyy}");
            Console.WriteLine($"Year:{dt:yyyy}, Month:{dt:MM}, Day:{dt:dd}");
            Console.WriteLine($"{dt,10:dddd}");
            Console.WriteLine($"{dt,10:hh:mm tt}{dt,10:dddd}");
            Console.WriteLine($"h:{dt:hh}, m:{dt:mm}, s:{dt:ss}");
            Console.WriteLine($"{dt:yyyy.MM.dd.hh.mm.ss}");
        }
        static void piFormatting() 
        {
            var pi = Math.PI;
            Console.WriteLine($"{pi:c}");
            Console.WriteLine($"{pi,10:n3}");
        }
    }
}