using System;
using System.Linq.Expressions;

namespace TimeSubstract
{
    class Program
    { 
        
        static void Main(string[] args)
        {
            TimeSpan span = new TimeSpan();
            int start_hours, start_minutes, finish_hours, finish_minutes;
            Console.WriteLine("Input the start hours");
            start_hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the minutes :");
            start_minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the fnish hours :");
            finish_hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the finish minutes :");
            finish_minutes = int.Parse(Console.ReadLine());
            DateTime start = new DateTime(2019, 1, 1, start_hours, start_minutes, 0);
            DateTime finish = new DateTime(2019, 1, 2, finish_hours, finish_minutes, 0);
            span = finish.Subtract(start);
            Console.WriteLine("Result : {0} hours, {1} minutes", span.Hours, span.Minutes);
            
            
            Console.Read();
        }
    }
}