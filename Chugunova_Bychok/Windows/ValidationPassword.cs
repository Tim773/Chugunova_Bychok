using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chugunova_Bychok.Windows
{
    public class ValidationPassword
    {
        public static bool ValidatePassword(string a)
        {
            
            if (a.Length >= 8 && a.Length <= 20)
            {


                //for (int i = 0; i <a.Length; i++ )
                //{
                //    if (a[i] >= '' && a[i] <= 57)
                //    {

                       
                //        return true;


                //    }
                //    else return false;
                //}


                //foreach (char ch in a)
                //{
                //    if (ch >= 48 && ch <= 57)
                //    {

                //        //foreach (char ch1 in a)
                //        //{
                //        //    if (ch1 >= 35 && ch1 <= 38 || ch1 == 94 || ch1 == 95)
                //        //    {
                //        //        foreach (char ch2 in a)
                //        //        {
                //        //            if (ch2 >= 65 && ch2 <= 90)
                //        //            {
                //        //                foreach (char ch3 in a)
                //        //                {
                //        //                    if (ch3 >= 97 && ch3 <= 122)
                //        //                    {
                //        //                        return true;
                //        //                    }
                //        //                    else return false;
                //        //                }
                //        //                return true;
                //        //            }
                //        //            else return false;
                //        //        }
                //        //        return true;
                //        //    }
                //        //    else return false;
                //        //}
                //        return true;
                //    }
                //    else return false;
                //}
                return true;
            }
            else return false;
            
        }
    }
}
