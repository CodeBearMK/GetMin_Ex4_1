namespace GetMin_Ex4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CMath cal1 = new CMath();
            int n1 = -20, n2 = 15;
            Console.WriteLine("{0},{1} 較小值為 {2}", n1, n2, cal1.GetMin(n1, n2));

            CMath cal2 = new CMath();
            int[] nAry = { -10, 0, 30, -12, 25 };
            Console.WriteLine("{0},{1},{2},{3},{4} 中最小值為 {5}",
                                nAry[0], nAry[1], nAry[2], nAry[3], nAry[4], cal2.GetMin(nAry));
            Console.Read();
        }
    }
}