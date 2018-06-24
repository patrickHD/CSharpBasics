using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Program
    {
        static void W(object s)
        {
            Console.Write(s);
        }
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            const byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            float mass = 14.6F;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";
            
            if(sample1 == sample2)
            {
                W("The samples are equal");
            }
            else
            {
                W("The samples are not equal.");
            }

            if (heartRate >= 40 && heartRate <= 80)
            {
                W("Heart rate is normal.");
            }
            else
            {
                W("Heart rate is not normal.");
            }
            if(deposits >= 100000000)
            {
                W("You are exceedingly wealthy.");
            }
            else
            {
                W("Sorry you are so poor.");
            }
            var force = mass * acceleration;
            W("force = " + force);
            W(distance + " is the distance");
            if(lost && expensive)
            {
                W("I am really sorry! I will get the manager.");
            }else if(lost && !expensive)
            {
                W("Here is coupon for 10% off.");
            }
            switch (choice)
            {
                case 1:
                    W($"You chose {choice}.");
                    break;
                case 2:
                    W($"You chose {choice}.");
                    break;
                case 3:
                    W($"You chose {choice}.");
                    break;
                default:
                    W("You made an unknown choice.");
                    break;
            }
            W(integral + " is an integral");
            for (int i = 5; i <= 10; i++)
            {
                W("i = " + i);
            }
            int age = 0;
            while(age < 6)
            {
                W($"age = {age}");
                age++;
            }
            W(greeting + " " + name);
            Console.ReadKey();
        }

        
    }
}
