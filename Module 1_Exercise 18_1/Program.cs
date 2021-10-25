using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char temp;

            Stack<char> stackForCheck = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                //Console.WriteLine(str[i]);
                if (str[i] == '(')
                {
                    Console.WriteLine("Я записываю в стек " + ')');
                    stackForCheck.Push(')');
                }
                else if (str[i] == '[')
                {
                    Console.WriteLine("Я записываю в стек " + ']');
                    stackForCheck.Push(']');
                }

                else if(str[i] == '{')
                {
                    Console.WriteLine("Я записываю в стек " + '}');
                    stackForCheck.Push('}');
                }
                
                else if (str[i] == ')')
                {
                    temp = stackForCheck.Pop();
                    if (temp != str[i])
                    {
                        Console.WriteLine("А тут вот у вас скобочка лишняя!");
                        break;
                    }

                }
                else if (str[i] == ']')
                {
                    temp = stackForCheck.Pop();
                    if (temp != str[i])
                    {
                        Console.WriteLine("А тут вот у вас скобочка лишняя!");
                        break;
                    }
                }
                else if (str[i] == '}')
                {
                    temp = stackForCheck.Pop();
                    if (temp != str[i])
                    {
                        Console.WriteLine("А тут вот у вас скобочка лишняя!");
                        break;
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine(stackForCheck.Count);

            if (stackForCheck.Count > 0)
            {
                Console.WriteLine("Все плохо, условие не выполнилось - в стеке остались символы!");
            }
            else
            {
                Console.WriteLine("Все хорошо, в стеке символов нет!");
            }

            Console.ReadKey();
        }
    }
}
