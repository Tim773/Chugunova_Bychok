using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chugunova_Bychok.Raschet
{
    public class Calculation
    {
        public static string GetBMI(double wight, double height)
        {
            double bmi = wight / (Math.Pow((height / 100), 2));
            if (bmi<=16)
            {
                return Math.Round(bmi).ToString() + " Выраженный дефицит массы тела";
            }

            else if (bmi>16 && bmi <=18.5)
            {
                return Math.Round(bmi).ToString() + " Недостаточна масса тела";
            }

            else if (bmi > 18.5 && bmi <= 24)
            {
                return Math.Round(bmi).ToString() + " Нормальная масса тела";
            }

            else if (bmi > 24 && bmi <= 30)
            {
                return Math.Round(bmi).ToString() + " Избыточная масса тела";
            }

            else if (bmi > 30 && bmi <= 35)
            {
                return Math.Round(bmi).ToString() + " Ожирение первой степени";
            }

            else if (bmi > 35 && bmi <= 40)
            {
                return Math.Round(bmi).ToString() + " Ожирение второй степени";
            }

            else
            {
                return "Ошибка при вводе данных";
            }
        }

        public static double GetBMR(double wight, double height, int gender, int age)
        {
            if (gender == 1)
            {
                return 66 + (13.7 * wight) + (5 * height) - (6.8 * age);
            }
            else if (gender == 2)
            {
                return 655 + (9.6 * wight) + (1.8 * height) - (4.7 * age);
            }
            else return 0;
        }
    }
}
