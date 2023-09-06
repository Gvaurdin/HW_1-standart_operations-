using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_standart_operations_
{
    internal class Program
    {
        static void Convert_registr(StringBuilder sb)
        {
            StringBuilder tmp = new StringBuilder();
            foreach (char c in sb.ToString())
            {
                if (char.IsUpper(c) && sb.Length > 0)
                    tmp.Append(char.ToLower(c));

                else if (char.IsLower(c) && sb.Length > 0)
                    tmp.Append(char.ToUpper(c));

                else if (c == ' ') tmp.Append(' ');

                else tmp.Append(c);

            }
            Console.Clear();
            Console.WriteLine("It was : " + sb.ToString());
            Console.WriteLine("Become : " + tmp.ToString());
        }

        static int Revers_number_v1(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("The number cannot be negative or zero");
                return 0;
            }
            else
            {
                int k = 1, tmp = num, kol = 1;
                while (tmp / k > 9) k *= 10;
                num = 0;
                do
                {
                    int buffer = tmp / k;
                    tmp -= buffer * k;
                    num += buffer * kol;
                    k /= 10;
                    kol *= 10;
                } while (k >= 1);
                return num;
            }
        }

        static int Revers_number_v2(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("The number cannot be negative or zero");
                return 0;
            }
            else
            {
                string value = num.ToString();
                string revers = "";
                int count = value.Length - 1;
                do
                {
                    revers += value.Substring(count, 1);
                    count--;
                } while (count != -1);

                num = int.Parse(revers);
                return num;
            }
        }

        static void Number_Generator(int a, int b)
        {
            if(a <= 0 || b <= 0)
            {
                Console.WriteLine("The number cannot be negative or zero");
                return;
            }
            else if(a > b) { int tmp = a; a = b; b = tmp;}
            Console.WriteLine("The number generator produced the following numbers:");
            for (int i = a; i <= b; i++)
            {
                for (global::System.Int32 j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void Menu()
        {
            char menu; bool flag = false;
            while (flag == false)
            {
                Console.Clear();
                Console.WriteLine("\t\tMenu change action\n" +
                    "\tEnter 1 to change registr string\n" +
                    "\tEnter 2 to revers number\n" +
                    "\tEnter 3 to generation numbers\n" +
                    "\tEnter 4 to exit\n" +
                    "Your action : ");
                menu = char.Parse(Console.ReadLine());
                while (menu != '1' && menu != '2' &&
                    menu != '3' && menu != '4')
                {
                    Console.WriteLine("Error input comand\n" +
                        "Try input comand again : ");
                }
                switch (menu)
                {
                    case '1':
                        {
                            Console.Clear();
                            StringBuilder sb = new StringBuilder();
                            Console.WriteLine("Enter to string : ");
                            sb.AppendLine(Console.ReadLine());
                            Convert_registr(sb);
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("Enter to number : ");
                            int num = Int32.Parse(Console.ReadLine());
                            int revers_num;
                            revers_num = Revers_number_v1(num);
                            Console.WriteLine("Your revers number (program version 1) : " + revers_num);
                            Console.WriteLine("\n==============================================\n");
                            revers_num = Revers_number_v2(num);
                            Console.WriteLine("Your revers number (program version 2 (check)) : " + revers_num);
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        {
                            Console.Clear();
                            int a, b;
                            Console.WriteLine("Enter to number a :");
                            a = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter to number b :");
                            b = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            Number_Generator(b, a);
                            Console.ReadKey();
                        }
                        break;
                    case '4':
                        {
                            Console.Clear();
                            Console.WriteLine("Exit from program...");
                            flag = true;
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
