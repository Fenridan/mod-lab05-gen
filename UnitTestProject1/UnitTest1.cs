using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Lab5;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = new int[31, 31];
            using (StreamReader r = new StreamReader("bgramm.txt"))
            {
                for (int i = 0; i < 31; i++)
                {
                    string test = r.ReadLine();
                    string[] temp = test.Split(new Char[] { ' ' });
                    int j = 0;
                    foreach (string item in temp)
                    {
                        array[i, j] = int.Parse(item);
                        j++;
                    }
                }
            }
            genBgramm genB = new genBgramm(array);
            Assert.IsTrue(genB.array[18,2] == 27);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[,] array = new int[31, 31];
            using (StreamReader r = new StreamReader("bgramm.txt"))
            {
                for (int i = 0; i < 31; i++)
                {
                    string test = r.ReadLine();
                    string[] temp = test.Split(new Char[] { ' ' });
                    int j = 0;
                    foreach (string item in temp)
                    {
                        array[i, j] = int.Parse(item);
                        j++;
                    }
                }
            }
            genBgramm genB = new genBgramm(array);
            Assert.IsTrue(genB.bagOfWords[0, 7] == 99);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] array_str = new string[100];
            using (StreamReader r = new StreamReader("words.txt"))
            {
                for (int i = 0; i < 100; i++)
                    array_str[i] = r.ReadLine();
            }
            genWord genW = new genWord(array_str);
            Assert.IsTrue(genW.bagOfWords[20] == 210);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string[] array_str = new string[100];
            using (StreamReader r = new StreamReader("words.txt"))
            {
                for (int i = 0; i < 100; i++)
                    array_str[i] = r.ReadLine();
            }
            genWord genW = new genWord(array_str);
            string ans = "";
            
            for (int i = 0; i < 100; i++)
            {
                string str = genW.getSym();
                for (int j = 0; j < str.Length; j++)
                    ans += str[j];
                ans += ' ';
            }
            int result = ans.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            Assert.AreEqual(result, 100);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string[] array_str = new string[100];
            using (StreamReader r = new StreamReader("pairs.txt"))
            {
                for (int i = 0; i < 100; i++)
                    array_str[i] = r.ReadLine();
            }
            genPairOfWords genP = new genPairOfWords(array_str);
            string ans = "";
            for (int i = 0; i < 100; i++)
            {
                string str = genP.getSym();
                for (int j = 0; j < str.Length; j++)
                    ans += str[j];
                ans += ' ';
            }

            int result = ans.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            Assert.AreEqual(result, 200);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string[] array_str = new string[100];
            using (StreamReader r = new StreamReader("pairs.txt"))
            {
                for (int i = 0; i < 100; i++)
                    array_str[i] = r.ReadLine();
            }
            genPairOfWords genP = new genPairOfWords(array_str);
            Assert.IsTrue(genP.bagOfWords[99] == 4950);
        }
    }

    
}
