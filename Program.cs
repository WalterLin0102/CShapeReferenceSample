using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeReferenceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //normal methor
            string test = "walter Test String。";
            int Num = 0;
            NormalMethor(test, Num);
            Console.WriteLine("Normal Methor Result.");
            System.Console.WriteLine("string = {0}, Num：{1}", test, Num);
            System.Console.WriteLine();
            //Ref methor
            string RefTest = "walter Test Ref String。";
            int RefNum = 0;
            RefMethor(ref RefTest, ref RefNum);
            Console.WriteLine("Ref Methor Result. ");
            System.Console.WriteLine("string = {0}, Num：{1}", RefTest, RefNum);

            System.Console.WriteLine();
            //Out methor
            /*
            若是給予非初始化的值也是可以，
            但是方法內一定會被調整，
            所以傳入的值有點變相等於沒差
            */
            OutMethor(out string OutTest, out int OutNum);
            Console.WriteLine("Out Methor Result. ");
            System.Console.WriteLine("string = {0}, Num：{1}", OutTest, OutNum);
            //After Redult
            OutTest = "walter Test Out Par.。";
            OutNum = 100;
            Console.WriteLine("After Result. ");
            System.Console.WriteLine("string = {0}, Num：{1}", OutTest, OutNum);

            System.Console.WriteLine();

            //In methor
            string InTest = "walter Test Out Par.。";
            int InNum = 100;

            InMethor(InTest, InNum);
            Console.WriteLine("In Methor Result. ");
            System.Console.WriteLine("string = {0}, Num：{1}", InTest, InNum);

            Console.ReadLine();
        }

        public static void NormalMethor(string StringTest, int Num)
        {
            StringTest = StringTest + Num.ToString();
            Num++;
        }

        public static void RefMethor(ref string StringTest, ref int Num)
        {
            StringTest = StringTest + "Orignal Num：" + Num.ToString();
            Num++;
        }

        public static void OutMethor(out string StringTest, out int Num)
        {
            StringTest = string.Empty;
            Num = 0;
            StringTest = StringTest + "Orignal Num：" + Num.ToString();
            Num++;
        }

        public static void InMethor(in string StringTest, in int Num)
        {
            //無法針對傳入in 的參數做任何的修改。
            string qwe = StringTest;
            int asd = Num;
        }
    }
}
