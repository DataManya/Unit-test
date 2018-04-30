using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClassLib.Tests
{
    [TestClass]
    public class MyClassTests
    {
        [TestMethod]
        public void Sum_elements()
        {
            // arrange
            
            //элементы массива
            int[,] IntArray = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    IntArray[0, 0] = 1;
                    IntArray[0, 1] = 9;
                    IntArray[1, 0] = 3;
                    IntArray[1, 1] = 0;
                }
            }
           
           //номер столбца
            int k = 0;

            //Сумма элеметов k-того столбца
            int expected = 4;


            // act
            MyClass c = new MyClass();
            int actual = c.Sum_of_column(k);


            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
