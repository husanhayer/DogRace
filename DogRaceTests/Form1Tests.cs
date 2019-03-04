using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogRace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRace.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void findWinnerTest()
        {
            Form1 objForm = new Form1();
            Race objRace = new Race();
            try {
                objRace.run(0);
            }
            catch (Exception ex) {
                StringAssert.Contains(ex.Message, " Error");
            }
            Assert.Fail();
        }

        [TestMethod()]
        public void chkReset()
        {
            Form1 objForm = new Form1();
            Race objRace = new Race();
            try
            {
                objRace.resetImage();
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, " Error");
            }
            Assert.Fail();
        }
    }
}