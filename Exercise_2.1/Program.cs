using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2._1
{
    
    class Program
    {
        static double Modull(ref double T_90)
        {
            return(Math.Sqrt(T_90*T_90));
        }
        static void Main(string[] args)
        {
            
            Random rHour = new Random(); // просто содаёт рандомное время для часов
            Random rMinute = new Random();
            double a = rHour.Next(0,12);
            double b = rMinute.Next(0, 59);          

            

            double triangleHour = a * 30; // создал переменные для  работы с ними
            double triangleMin = b * 6;            // трианглеМин - это а самом деле угол, просто я бог английского пока)))
            double distance;
            double speed = 6 - 0.5;  // стоит ли создавать перемемнную чтобы все всё было в коде понятно или лучше не надо?


            if (triangleHour - triangleMin>=0)
            {
                distance = 90 - (360 - triangleHour) - triangleMin;

            }                
            else if ((triangleHour - triangleMin) == 90 && (triangleHour - triangleMin) == -90 && (triangleHour - triangleMin) == 270 && (triangleHour - triangleMin) == -270)
            {
                distance = 0;
            }
            else
            {
                distance = 360 - triangleMin - triangleHour + 90;
            }            

            double t_90 = (double)(distance / speed);

            // t_90 >= 0 ? t_90++ :t_90=t_90*-1; //Why it is not working?

            Modull(ref t_90);

            t_90 = Math.Truncate(t_90);

            Console.WriteLine("Часы " + a + " минуты " + b + " Ответ: Время за которое стрелки станут перендикулярны друг другу равно " + (t_90) + " минут");



// Вычисляет через сколько минут стрелки встретятся



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
            }
        }
    }
}
