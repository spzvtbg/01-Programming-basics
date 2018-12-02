using System;
namespace Grades
{
    class grades
    {
        static void Main()
        {
            double numOfStudents = double.Parse(Console.ReadLine());
            double topStudents = 0;
            double betweenPlusStudents = 0;
            double betweenStudents = 0;
            double failStudents = 0;
            double average = 0;
            for (int i = 1; i <= numOfStudents; i++)
            {
                double evaluation = double.Parse(Console.ReadLine());
                average = average + evaluation;
                if (evaluation >= 2.00 && evaluation < 3.00)
                {
                    failStudents++;
                }
                if (evaluation >= 3.00 && evaluation < 4.00)
                {
                    betweenStudents++;
                }
                if (evaluation >= 4.00 && evaluation < 5.00)
                {
                    betweenPlusStudents++;
                }
                if (evaluation >= 5.00)
                {
                    topStudents++;
                }
            }
            failStudents = (failStudents / numOfStudents) * 100;
            betweenStudents = (betweenStudents / numOfStudents) * 100;
            betweenPlusStudents = (betweenPlusStudents / numOfStudents) * 100;
            topStudents = (topStudents / numOfStudents) * 100;
            average = average / numOfStudents;
            Console.WriteLine("Top students: {0:f2}%", topStudents);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", betweenPlusStudents);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", betweenStudents);
            Console.WriteLine("Fail: {0:f2}%", failStudents);
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
