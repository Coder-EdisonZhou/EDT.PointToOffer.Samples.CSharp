using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sobey.PointToOffer.ReplaceBlank;

namespace Sobey.PointToOffer.ReplaceBlank.UnitTest
{
    [TestClass]
    public class ReplaceBlankUnitTest
    {
        const int maxLength = 100;
        char[] target = new char[maxLength];
        // Pre-Test
        [TestInitialize]
        public void ReplaceBlankInitialize()
        {
            for (int i = 0; i < maxLength; i++)
            {
                target[i] = '\0';
            }
        }

        public char[] GenerateNewTarget()
        {
            int length = 0;
            for (int i = 0; i < maxLength && target[i] != '\0'; i++)
            {
                length++;
            }

            char[] newTarget = new char[length];

            for (int i = 0; i < maxLength && target[i] != '\0'; i++)
            {
                newTarget[i] = target[i];
            }

            return newTarget;
        }

        // Test1:空格在句子中间
        [TestMethod]
        public void ReplaceBlankTest1()
        {
            // "hello world"
            target[0] = 'h';
            target[1] = 'e';
            target[2] = 'l';
            target[3] = 'l';
            target[4] = 'o';
            target[5] = ' ';
            target[6] = 'w';
            target[7] = 'o';
            target[8] = 'r';
            target[9] = 'l';
            target[10] = 'd';

            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "hello%20world";

            Assert.AreEqual(compared, expected);
        }

        // Test2:空格在句子开头
        [TestMethod]
        public void ReplaceBlankTest2()
        {
            // " helloworld"
            target[0] = ' ';
            target[1] = 'h';
            target[2] = 'e';
            target[3] = 'l';
            target[4] = 'l';
            target[5] = 'o';
            target[6] = 'w';
            target[7] = 'o';
            target[8] = 'r';
            target[9] = 'l';
            target[10] = 'd';

            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "%20helloworld";

            Assert.AreEqual(compared, expected);
        }

        // Test3:空格在句子末尾
        [TestMethod]
        public void ReplaceBlankTest3()
        {
            // "helloworld "
            target[0] = 'h';
            target[1] = 'e';
            target[2] = 'l';
            target[3] = 'l';
            target[4] = 'o';
            target[5] = 'w';
            target[6] = 'o';
            target[7] = 'r';
            target[8] = 'l';
            target[9] = 'd';
            target[10] = ' ';

            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "helloworld%20";

            Assert.AreEqual(compared, expected);
        }

        // Test4:连续有两个空格
        [TestMethod]
        public void ReplaceBlankTest4()
        {
            // "helloworld "
            target[0] = 'h';
            target[1] = 'e';
            target[2] = 'l';
            target[3] = 'l';
            target[4] = 'o';
            target[5] = ' ';
            target[6] = ' ';
            target[7] = 'w';
            target[8] = 'o';
            target[9] = 'r';
            target[10] = 'l';
            target[11] = 'd';

            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "hello%20%20world";

            Assert.AreEqual(compared, expected);
        }

        // Test5:传入NULL
        [TestMethod]
        public void ReplaceBlankTest5()
        {
            target = null;
            Program.ReplaceBlank(target, 0);
            char[] expected = null;

            Assert.AreEqual(target, expected);
        }

        // Test6:传入内容为空的字符串
        [TestMethod]
        public void ReplaceBlankTest6()
        {
            // ""
            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "";

            Assert.AreEqual(compared, expected);
        }

        // Test7:传入内容为一个空格的字符串
        [TestMethod]
        public void ReplaceBlankTest7()
        {
            // " "
            target[0] = ' ';

            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "%20";

            Assert.AreEqual(compared, expected);
        }

        // Test8:传入的字符串没有空格
        [TestMethod]
        public void ReplaceBlankTest8()
        {
            // "helloworld "
            target[0] = 'h';
            target[1] = 'e';
            target[2] = 'l';
            target[3] = 'l';
            target[4] = 'o';
            target[5] = 'w';
            target[6] = 'o';
            target[7] = 'r';
            target[8] = 'l';
            target[9] = 'd';

            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "helloworld";

            Assert.AreEqual(compared, expected);
        }

        // Test9:传入的字符串全是空格
        [TestMethod]
        public void ReplaceBlankTest9()
        {
            // "     "
            target[0] = ' ';
            target[1] = ' ';
            target[2] = ' ';
            target[3] = ' ';
            target[4] = ' ';

            Program.ReplaceBlank(target, maxLength);
            string compared = new string(this.GenerateNewTarget());
            string expected = "%20%20%20%20%20";

            Assert.AreEqual(compared, expected);
        }
    }
}
