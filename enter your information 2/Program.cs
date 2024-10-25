using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace enter_your_information_2
{
    internal class Program
    {
        public static void Welcome(string firstname)
        {
            Console.WriteLine($"hello! welcome {firstname} to our app");
            Console.WriteLine("I hope you enjoy this app");
        }
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static int Add(int num1, int num2, int num3)
        {
            int result = num1 + num2 + num3;
            return result;
        }
        public static int Fibonachi(int n)
        {
            int a = 0;
            int b = 1;
            for (int x = 0; x < n; x++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main(string[] args)
        {
            {
                // پرسیدن نام

                Console.WriteLine("What is your firstname?");
                string firstname = Console.ReadLine() ?? "";
                if (firstname == "")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("please enter your name!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                firstname = firstname.Trim().ToLower();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Welcome(firstname);


                //پرسیدن فامیلی

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("whar is your lastname ?");
                string? lastname = Console.ReadLine() ?? "";
                if (lastname == "")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("please enter your last name!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                lastname = lastname.Trim().ToLower();


                //پرسیدن شماره تلفن

                do
                {
                    Console.WriteLine("what is your mobile number ?");
                    string mobilenumber = Console.ReadLine() ?? string.Empty;
                    if (string.IsNullOrEmpty(mobilenumber))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("please enter valid mobilenumber");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                    }
                    mobilenumber = mobilenumber.Trim();
                    if (mobilenumber.StartsWith("+98"))
                        mobilenumber = mobilenumber.Replace("+98", "0");
                    if (mobilenumber.Length == 11 && mobilenumber.StartsWith("0"))
                    {
                        try
                        {
                            long mobileNum = long.Parse(mobilenumber);
                            Console.WriteLine("thank you");
                            break;
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("please enter valid mobilenumber ");
                        }
                    }
                } while (true);
                Console.ForegroundColor = ConsoleColor.White;


                //پرسیدن سن

                Console.WriteLine("how old are you ?");
                int age = int.Parse(Console.ReadLine());
                if (age > 120)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("you are too old and you are not valid to enter the site");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (age < 15)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("you are not valid to enter the site");
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("you are valid to enter the site");
                    Console.ForegroundColor = ConsoleColor.White;
                }


                //نشان دادن اطلاعات در قالب جمله

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                string description = "your first name is :" + firstname
                + "\n\"your last name is:" + lastname
                + "\n\"your age is :" + age;
                Console.WriteLine(description);


                // برای جمع دو عدد

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("please enter 2 number");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = Add(num1, num2);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"the result is {result}");


                // برای جمع سه عدد

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("please enter 3 number ");
                int num3 = int.Parse(Console.ReadLine());
                int num4 = int.Parse(Console.ReadLine());
                int num5 = int.Parse(Console.ReadLine());
                int result2 = Add(num3, num4, num5);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"the result is : {result2}");


                // برای بخش پذیری دو عدد

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("please enter 2 number");
                int num6 = int.Parse(Console.ReadLine());
                int num7 = int.Parse(Console.ReadLine());
                if (num6 > num7)
                {
                    if (num6 % num7 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("bar ham bakhsh pazirand");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("bar ham bakhsh pazir nistand");
                    }
                }
                else
                {
                    if (num7 % num6 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("bar ham bakhsh paszir hastand");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("bar ham bakhsh pazir nistand");
                    }
                }


                //برای تشخیص اعداد زوج و فرد

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("please enter a number");
                int num8 = int.Parse(Console.ReadLine());
                if (num8 % 2 == 0)
                    Console.WriteLine("zoj");
                else
                    Console.WriteLine("fard");


                // برای تشخیص عدد کوچکتر بین 2 عدد
                
                Console.WriteLine("please enter 2 number");
                int num9 = int.Parse(Console.ReadLine());
                int num10 = int.Parse(Console.ReadLine());
                if (num9 < num10)
                    Console.WriteLine($"the smaller number is : {num9}");
                else
                    Console.WriteLine($"the smaller number is : {num10}");


                // برای تشخیص عدد کوچکتر بین 3 عدد
                
                int num11 = int.Parse(Console.ReadLine());
                int num12 = int.Parse(Console.ReadLine());
                int num13 = int.Parse(Console.ReadLine());
                if (num11 < num12 && num11 < num13)
                    Console.WriteLine($"the smallest number is : {num11}");
                else if (num12 < num11 && num12 < num13)
                    Console.WriteLine($"the smallest number is : {num12}");
                else
                    Console.WriteLine($"the smallest number is {num13}");


                // برای اعداد حسابی 
                
                Console.WriteLine("mikhahid donbale hesabi ta chand adad edame dashte bashad ?");
                int num14 = int.Parse(Console.ReadLine());
                for (int i = 0; i <= num14; i++)
                    Console.WriteLine(i);


                //برای دنباله فیبوناچی 
                
                Console.WriteLine("donbale fibonachi ta chand adad mikhahid edame dashte bashad ?");
                int n= int.Parse(Console.ReadLine());
                for (int x = 0; x <= n; x++)
                    Console.WriteLine(Fibonachi(x));
                }
            }

        }
    }
