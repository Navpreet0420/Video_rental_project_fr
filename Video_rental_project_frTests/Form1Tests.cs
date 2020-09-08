using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_project_fr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_project_fr.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Member member = new Member();
            int y=member.countBooking(1);
            if (y>=2) {
                Assert.IsTrue(true);
            }
        }


        [TestMethod()]
        public void Form2Test()
        {
            Video video = new Video();
            int y = video.countCopy(1);
            if (y > 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }



    }
}