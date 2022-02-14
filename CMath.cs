using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMin_Ex4_1
{
    internal class CMath
    {
        public int GetMin(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }

        public int GetMin(int[] numAry)
        {
            int min = numAry[0];
            for (int i = 1; i < numAry.Length; i++)
            {
                if (numAry[i] < min)
                {
                    min = numAry[i];
                }
            }
            return min;
        }
    }
}
