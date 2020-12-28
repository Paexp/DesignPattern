using System;

namespace SimpleFactory
{
    internal class Program
    {
        /*
         * 请用C++、Java、C#或VB.NET任意一种面向对象语言实现一个计算器控制台程序
         * 要求：输入两个数和运算符号，得到结果
         */
        private static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请输入运算符号（+、-、*、/）：");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";

                Operation oper;
                oper = OperationFactory.createOperate(strOperate);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);

                double result = oper.GetResult();
                strResult = Convert.ToString(result);

                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }
        }
    }
}