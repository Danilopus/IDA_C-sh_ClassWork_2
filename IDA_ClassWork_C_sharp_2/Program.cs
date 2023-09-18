


// Array /// String


using System.Data;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
/// ClassWork 18.09.2023
namespace IDA_ClassWork_C_sharp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Arrays();

            // ForEach();

            //  OddEven();

            // OddEven_random();

            WordCount();

            Console.ReadKey();

        }
        static void Arrays()
        {
            int size = 10;
            int cols = 5, rows = 10;

            // 1 - DIM
            int[] int_array = new int[size];

            // 2 - DIM
            int[,] int_array_2 = new int[cols, rows];

            // 3 - jagged (вложенные массивы разного размера)
            int[][] int_jagged_array_3 = new int[3][];

            int_jagged_array_3[0] = new int[size];
            int_jagged_array_3[1] = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Jagged arrays: ");
            Console.WriteLine(int_jagged_array_3[0][5]);
            Console.WriteLine(int_jagged_array_3[1][2]);
            //Console.WriteLine(int_jagged_array_3[2][2]);
        }
        static void ForEach()
        {
            int size = 10;
            int[] int_array = new int[size];

            foreach (var i in int_array)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.WriteLine(int_array[i]);
            }
        }
        static void String()
        {
            string str_temp;
        }
        static void Enums()
        {
            MyEnum enum_var = MyEnum.onein;
            Console.WriteLine(enum_var);
        }
        enum MyEnum { onein, twoin, threein }


        static void OddEven()
        {
           Console.Write("Enter size ");

            int size = Convert.ToInt32(Console.Read());

            int[] test_array = new int[size];
            Console.WriteLine(test_array.Length);

            int OddCount = 0, EvenCount = 0, UniqCount = size;

            //foreach (int i in test_array)
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter [" + i + "] ");
                test_array[i] = Convert.ToInt32(Console.Read());
                if (test_array[i] % 2 == 0) EvenCount++;
                else OddCount++;

                for (int ii = 0; ii < i; ii++)
                {
                    if (test_array[ii] == test_array[i]) UniqCount--;
                }

            }

            Console.WriteLine("OddCount " + OddCount);
            Console.WriteLine("EvenCount " + EvenCount);
            Console.WriteLine("UniqCount " + UniqCount);



            //foreach (var i in test_array)



        }

        static void OddEven_random()
        {

            int size = Convert.ToInt32(Console.ReadLine());
            //int size = 5;

            int[] test_array = new int[size];
            //int[] test_array = new int[] { 1, 2, 3, 4, 5, 5,5,5,5 };

            //test_array.Count;

            int OddCount = 0, EvenCount = 0, UniqCount = 0;
            Random rnd = new Random();


            for (int i = 0; i < test_array.Length; i++)
            {
               test_array[i] = rnd.Next(1, 10);

                if (test_array[i] % 2 == 0) EvenCount++;
                else OddCount++;
            }
            
            bool unique = false;

            for (int I = 0; I< test_array.Length; I++)
            {
                unique = true;
                for (int i = 0; i < test_array.Length; i++)
                {
                    if (i == I) break;
                    if (test_array[I] == test_array[i]) unique = false;
                    
                }
                if (unique) UniqCount++;
            }





            Console.WriteLine("OddCount " + OddCount);
            Console.WriteLine("EvenCount " + EvenCount);
            Console.WriteLine("UniqCount " + UniqCount);



            //foreach (var i in test_array)



        }

        static void WordCount()
        {
            Console.WriteLine("Enter a sentence\n");
            // string? test_str = Console.ReadLine();

             //string test_str = "Now is the time for all good men to come to the aid of their country"; // 16 words
            //string test_str = "Now is the     time for all good men to come to the aid of their country     "; // 16 words
            string test_str = "Now is the     time for all good men to come to the aid of their country"; // 16 words
            //string test_str = "   Now is the     time for all good men to    come to the aid of their country    " ; // 16 words


            //int test_int = 5;
            //int* int_ptr = &test_int;


            int index = 0;
            int space_counter = 0;

            while (true)
            {
               index = test_str.IndexOf(" ", index+1);
               if (index == -1 || index == test_str.Length-1) break;
               if (test_str[index] == test_str[index + 1]) continue;
               //if (test_str[index] == test_str[index - 1]) continue;

                space_counter++;
            }

            Console.WriteLine("word_counter " + (space_counter+1));

        }


    }

}
//enum MyEnum {one, two, three}



