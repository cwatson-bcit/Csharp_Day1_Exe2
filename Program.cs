using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //Ask the user to Enter Student Details
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("---------------------");
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("\nEnter Marks of three Subjects:");
            Console.Write("Subject1: ");
            int Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Subject2: ");
            int Mark2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Subject3: ");
            int Mark3 = Convert.ToInt32(Console.ReadLine());
            int TotalMarks = Mark1 + Mark2 + Mark3;
            int AverageMark = TotalMarks / 0;

            //Display the Student Details
            Console.WriteLine("\nStudent Details are as Follows");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Total Marks : {TotalMarks}");
            Console.WriteLine($"Average Mark: {AverageMark}");
            Console.ReadLine();
        }
    }
}
