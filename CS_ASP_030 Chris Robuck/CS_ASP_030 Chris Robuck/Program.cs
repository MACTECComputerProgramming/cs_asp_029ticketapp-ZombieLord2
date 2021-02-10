using System;

namespace CS_ASP_030_Chris_Robuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentNum;
            int speedLimit;
            int ticketSpeed;
            int grade;
            string yearInSchool;
            int speed;
            double fine;

            Console.WriteLine("Enter Student Number :");
            studentNum = Console.ReadLine();
            Console.Write("Enter The Grade Level, 1 For Freshman, 2 For Sophmore, 3 For Junior, & 4 For Senior :");
            grade = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed Limit :");
            speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ticketed Speed :");
            ticketSpeed = int.Parse(Console.ReadLine());

            Console.Clear();
             Console.WriteLine("Student Number : " + studentNum);

            switch (grade)
            {
                case 1: yearInSchool = "Freshman";
                    Console.WriteLine("The Student Is A " + yearInSchool);
                    break;
                case 2: yearInSchool = "Sophmore"; 
                    Console.WriteLine("The Student Is A " + yearInSchool);
                    break;
                case 3: yearInSchool = "Junior"; 
                    Console.WriteLine("The Student Is A " + yearInSchool);
                    break;
                case 4: yearInSchool = "Senior"; 
                    Console.WriteLine("The Student Is A " + yearInSchool);
                    break;
                default:
                    break;
            }

            speed = ticketSpeed - speedLimit;
            fine = (speed / 5 * 87.50);
            if (grade == 4)
            {
                if (speed>20)
                {
                    fine = fine + 200;
                }
                else
                {
                    fine = fine + 50;
                }
            }
            else
            {
                if (grade == 1)
                {
                    if (speed<20)
                    {
                        fine = fine - 50;
                    }
                    else
                    {
                        fine = fine + 100;
                    }
                }
                else
                {
                    if (speed>19)
                    {
                        fine = fine + 100;                   
                    }
                }
            }
            Console.WriteLine("Speed Limit : " + speedLimit);
            Console.WriteLine("Reported Speed : " + ticketSpeed);
            Console.WriteLine("Amount Of Fine : " + fine);

        }

        
    }
}
