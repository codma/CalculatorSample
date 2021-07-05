using System;

namespace SampleSimmariazi
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (; ; )
            //무한으로 물어봄
            {
                Console.WriteLine("두개의 숫자를 입력할거에요");
                Console.WriteLine("첫번째 숫자를 입력해주세요");
                string firstNum = Console.ReadLine();
                Console.WriteLine("두번째 숫자를 입력해주세요");
                string secondNum = Console.ReadLine();
                //Console.WriteLine(int.Parse(firstNum) + int.Parse(secondNum));
                Console.WriteLine("연산자를 입력해주세요");

                string oper = Console.ReadLine();

                int result = 0;
                //초기화 하는 값을 넣어줌. 넣지 않으면 쓰레기값이 들어가
                if (oper == "+")
                {
                    result = Plus(int.Parse(firstNum), int.Parse(secondNum));
                }
                else if (oper == "-")
                {
                    result = Minus(int.Parse(firstNum), int.Parse(secondNum));
                }
                else if (oper == "*")
                {
                    result = Multi(int.Parse(firstNum), int.Parse(secondNum));
                }
                else if (oper == "/")
                {
                    result = Div(int.Parse(firstNum), int.Parse(secondNum));
                }




                Console.Write("값 = ");
                Console.WriteLine(result);
            }
        }
        public static int Plus(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        public static int Minus(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        public static int Multi(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        public static int Div(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
