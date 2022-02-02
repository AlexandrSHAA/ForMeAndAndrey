using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2._1
{
    
    class Program
    {
        static uint OneMinetPlus(double triangleH, double triangleM, uint count)
        {
            if (triangleH >= triangleM)
            {
                double distance = triangleH - triangleM;

                if (distance==90)
                {
                    return (count + 1);
                }
                else if (triangleM >= 360& triangleH >= 360)
                {

                }
                else
                {
                    OneMinetPlus(triangleH + 0.5, triangleM + 6, count + 1);
                }

            }
            else
            {
                double distance = triangleM - triangleH;

                if (distance == 90)
                {
                    return (count + 1);
                }
                else
                {
                    OneMinetPlus(triangleH + 0.5, triangleM + 6, count + 1);
                }
                
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random rHour = new Random();
            Random rMinute = new Random();
            double a = rHour.Next(0,12);
            double b = rMinute.Next(0, 59);          

            

            double triangleHour = a * 30;
            double triangleMin = b * 6;
            uint count = 0;

            while (true)
            {


                if (triangleHour >= triangleMin)
                {
                    double distance = triangleHour - triangleMin;

                    if (distance == 90)
                    {
                        Console.WriteLine((count + 1));
                        break;
                    }
                    else if (triangleMin > 360)
                    {
                        double y = 360 - (triangleMin - 6);
                        triangleMin = (0 + y);
                    }
                    else if(triangleHour > 360)
                    {
                        double y = 360 - (triangleHour - 0.5);
                        triangleMin = (0 + y);
                    }
                    else
                    {
                        triangleHour += 0.5;
                        triangleMin += 6; 
                        count += 1;
                    }

                }
                else
                {
                    double distance = triangleMin - triangleHour;

                    if (distance == 90)
                    {
                        Console.WriteLine((count + 1));
                        break;
                    }
                    else if (triangleMin > 360)
                    {
                        double y = 360 - (triangleMin - 6);
                        triangleMin = (0 + y);
                    }
                    else if (triangleHour > 360)
                    {
                        double y = 360 - (triangleHour - 0.5);
                        triangleMin = (0 + y);
                    }
                    else
                    {
                        triangleHour += 0.5;
                        triangleMin += 6;
                        count += 1;
                        continue;
                    }
                }


            }






/*

                double speed = 6 - 0.5;




            if (triangleHour > triangleMin)
            {
                double distants = triangleHour - triangleMin;                

                double answer = distants / speed;

                answer = Math.Truncate(answer);

                Console.WriteLine("Часы " + a + " минуты " + b + " Ответ " + answer);
            }
            else
            {
                double distants = triangleHour + ((360- triangleMin)/5);                
                
                double answer = distants / speed;
                
                answer = Math.Truncate(answer);

                Console.WriteLine("Часы " + a + " минуты " + b + " Ответ " + (answer + 60));
            }*/
        }
    }
}
