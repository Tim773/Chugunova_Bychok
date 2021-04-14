using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chugunova_Bychok.Test
{ 

    [TestClass]
    public class ValidationPasswordTest
    {

        //длина пароля меньше 8/////////////////////////////////////////////////
        [TestMethod]
        public void ValidatePassword_QwE123m__truereturn()
        {   //arrage
            string pass = "QwE123m_";
            bool res = true;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);

        }

        [TestMethod]
        public void ValidatePassword_Qerttr_falsereturn()
        {   //arrage
            string pass = "Q1rt#";
            bool res = false;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }
       
        
        //наличие цифр//////////////////////////////////////////////////
        [TestMethod]
        public void ValidatePassword_QwE143m__truereturn()
        {   //arrage
            string pass = "QwE143m_";
            bool res = true;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);

        }

        [TestMethod]
        public void ValidatePassword_Qerootur_falsereturn()
        {   //arrage
            string pass = "Qero*tur";
            bool res = false;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }

        //наличие спец символов///////////////////////////////////////////////////
        [TestMethod]
        public void ValidatePassword_QwK_143m__truereturn()
        {   
            //arrage
            string pass = "QwK#143m_";
            bool res = true;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }

        [TestMethod]
        public void ValidatePassword_Qer2otur_falsereturn()
        {   
            //arrage
            string pass = "Qer2otur";
            bool res = false;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }
        //наличие букв верхнего регистра/////////////////////////////////////////////////////////////
        [TestMethod]
        public void ValidatePassword_QwKu143m__truereturn()
        {
            //arrage
            string pass = "QwKu143m_";
            bool res = true;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }

        [TestMethod]
        public void ValidatePassword_qer2otur_falsereturn()
        {
            //arrage
            string pass = "qer2otur";
            bool res = false;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }
        //наличие букв нижнего регистра//////////////////////////////////////////////////////////////
        [TestMethod]
        public void ValidatePassword_QwK6143m__truereturn()
        {
            //arrage
            string pass = "QwK6143m_";
            bool res = true;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }

        [TestMethod]
        public void ValidatePassword_QE_R3YI4O_falsereturn()
        {
            //arrage
            string pass = "QE_R3YI4O";
            bool res = false;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }
        //длина пароля больше 20/////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void ValidatePassword_QwK6543m__truereturn()
        {
            //arrage
            string pass = "QwK6543m_";
            bool res = true;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }

        [TestMethod]
        public void ValidatePassword_QE_R3YI4OFrtyPo734723bbsadj346r563dhj___hjdfhjd32424sdfr_falsereturn()
        {
            //arrage
            string pass = "QE_R3YI4OFrtyPo734723bbsadj346r563dhj___hjdfhjd32424sdfr";
            bool res = false;
            //act
            bool result = Chugunova_Bychok.Windows.ValidationPassword.ValidatePassword(pass);

            //assert

            Assert.AreEqual(res, result);
        }
    }
}
