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



    }
}
