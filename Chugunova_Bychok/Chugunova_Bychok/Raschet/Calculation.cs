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
    }
}
