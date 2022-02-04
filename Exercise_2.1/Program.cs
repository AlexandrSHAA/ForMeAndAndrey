using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2._1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rHour = new Random();
            Random rMinute = new Random();
            double a = rHour.Next(0,12);
            double b = rMinute.Next(0, 59);          

            

            double triangleHour = a * 30;
            double triangleMin = b * 6;
            uint count = 0;
            double distance = 0;

           

            if (triangleHour - triangleMin>=0)
            {
                distance = 90 - (360 - triangleHour) - triangleMin;

            }                
            if else (triangleHour - triangleMin == 90 && triangleHour - triangleMin == -90 && triangleHour - triangleMin == 270 && triangleHour - triangleMin == -270)
            {
                distance = 0;
            }
            else
            {
                distance = 360 - triangleMin - triangleHour + 90;
            }

            double t_90 = (double)(distance / 5.5);
            Console.WriteLine("Часы " + a + " минуты " + b + " Ответ: количество минут до того как стрелка достигнет 90 градусов " + (t_90));







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
