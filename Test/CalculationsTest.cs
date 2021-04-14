using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chugunova_Bychok.Test
{
    [TestClass]
    public class CalculationsTest
    {
        [TestMethod]
        public void GetBMI_50and170_17returned()
        {
            //arrage
            double ves = 50;
            double rost = 170;
            string imb = "17 Недостаточна масса тела";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_100and160_39returned()
        {

            //arrage
            double ves = 100;
            double rost = 160;
            string imb = "39 Ожирение второй степени";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_60and160_23returned()
        {

            //arrage
            double ves = 60;
            double rost = 160;
            string imb = "23 Нормальная масса тела";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_50and180_15returned()
        {

            //arrage
            double ves = 50;
            double rost = 180;
            string imb = "15 Выраженный дефицит массы тела";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_55and180_17returned()
        {

            //arrage
            double ves = 55;
            double rost = 180;
            string imb = "17 Недостаточна масса тела";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_90and180_28returned()
        {

            //arrage
            double ves = 90;
            double rost = 180;
            string imb = "28 Избыточная масса тела";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_100and180_31returned()
        {

            //arrage
            double ves = 100;
            double rost = 180;
            string imb = "31 Ожирение первой степени";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_90and186_26returned()
        {

            //arrage
            double ves = 90;
            double rost = 186;
            string imb = "26 Избыточная масса тела";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }

        [TestMethod]
        public void GetBMI_45and155_19returned()
        {

            //arrage
            double ves = 45;
            double rost = 155;
            string imb = "19 Нормальная масса тела";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }


        [TestMethod]
        public void GetBMI_0and0_Errorreturned()
        {

            //arrage
            double ves = 0;
            double rost = 0;
            string imb = "Ошибка при вводе данных";

            //act
            string result = Chugunova_Bychok.Raschet.Calculation.GetBMI(ves, rost);

            //assert

            Assert.AreEqual(imb, result);
        }






        [TestMethod]
        public void GetBMR_0and0and0and0_0returned()
        {

            //arrage
            double ves = 0;
            double rost = 0;
            int gender = 0;
            int age = 0;
            double bmr = 0;
          

            //act
            double result = Chugunova_Bychok.Raschet.Calculation.GetBMR(ves, rost, gender, age);

            //assert

            Assert.AreEqual(bmr, result);
        }

        [TestMethod]
        public void GetBMR_50and180and1and24_1487returned()
        {

            //arrage
            double ves = 50;
            double rost = 180;
            int gender = 1;
            int age = 24;
            double bmr = 1487.8;


            //act
            double result = Chugunova_Bychok.Raschet.Calculation.GetBMR(ves, rost, gender, age);

            //assert

            Assert.AreEqual(bmr, result);
        }

        [TestMethod]
        public void GetBMR_100and170and1and18_2163returned()
        {

            //arrage
            double ves = 100;
            double rost = 170;
            int gender = 1;
            int age = 18;
            double bmr = 2163.6;


            //act
            double result = Chugunova_Bychok.Raschet.Calculation.GetBMR(ves, rost, gender, age);

            //assert

            Assert.AreEqual(bmr, result);
        }
        [TestMethod]
        public void GetBMR_100and170and2and18_1836returned()
        {

            //arrage
            double ves = 100;
            double rost = 170;
            int gender = 2;
            int age = 18;
            double bmr = 1836.4;


            //act
            double result = Chugunova_Bychok.Raschet.Calculation.GetBMR(ves, rost, gender, age);

            //assert

            Assert.AreEqual(bmr, result);
        }

        [TestMethod]
        public void GetBMR_50and180and2and24_1346returned()
        {

            //arrage
            double ves = 50;
            double rost = 180;
            int gender = 2;
            int age = 24;
            double bmr = 1346.2;


            //act
            double result = Chugunova_Bychok.Raschet.Calculation.GetBMR(ves, rost, gender, age);

            //assert

            Assert.AreEqual(bmr, result);
        }


    }
}
