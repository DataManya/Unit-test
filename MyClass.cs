using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class MyClass
    {
        public int Sum_of_column(int k) //Метод, позволяющий вычислить сумму элеметов k-того столбца. 
        {

            {
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

                int sum = 0;
                return sum = IntArray[0, k] + IntArray[1, k];
            }
        }
    }
}
