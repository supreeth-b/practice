using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    interface I1
    {
        void abc();
    }
    class Program : I1
    {
        public void abc()
        {

        }
        static void Main(string[] args)
        {
            try
            {
                //Hi
                //I1 p1 = new Program();
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
                arr = NoOdds(arr);

                double[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8 };
                arr2 = MinMaxLengthAverage(arr2);

                string str3 = "Hello World";
                str3 = Reverse(str3);

                Console.WriteLine(str3);

                str3 = "Hello World";
                str3 = ReverseOldMechanism(str3);

                foreach (var item in arr2)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(DoubleLetters("basghsghakshskk"));
                Console.WriteLine(ReverseCase("HallOO GaiS"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

        public static int[] NoOdds(int[] arr)
        {
            return arr.Where(n => n % 2 == 0).ToArray();
        }

        public static double[] MinMaxLengthAverage(double[] arr)
        {
            return new double[] { arr.Min(), arr.Max(), arr.Length, arr.Average() };
        }

        public static string Reverse(string str3)
        {
            return string.Concat(str3.Reverse());
        }

        public static string ReverseOldMechanism(string str3)
        {
            string str4 = "";
            for (int i = 0; i < str3.Length; i++)
            {
                str4 = str3[i] + str4;
            }
            return str4;
        }

        public static bool DoubleLetters(string str)
        {
            bool a = false;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    a = true;
                }
            }
            return a;
        }

        public static string ReverseCase(string str)
        {
            return new string(str.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)).ToArray());
        }



    };
    interface IOne
    {
        void one();
    }

    class One : IOne
    {
        public void one()
        {
        }
    }
}
