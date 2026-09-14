using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace calc;

class Program
{
    static void Main()
    {
        bool flag1_ = false;
        bool flag2_ = false;
        string operator_;
        double result_double;
        long result_int;
        
        System.Console.WriteLine("Добро пожаловать в консольный калькулятор! для продолжения нажмите enter");
        
        while (System.Console.ReadLine() != "exit")
        {
            System.Console.WriteLine("Введите первое значение: ");
            string arg_1 = System.Console.ReadLine();
            System.Console.WriteLine("Первое значение {0}", arg_1);

            System.Console.WriteLine("Введите второе значение: ");
            string arg_2 = System.Console.ReadLine();
            System.Console.WriteLine("Второе значение {0}", arg_2);
            
            foreach (char search in arg_1)
            {
                if (search == '.' || search == ',')
                {
                    flag1_ = true;
                    break;
                }
            }
            foreach (char search in arg_2)
            {
                if (search == '.' || search == ',')
                {
                    flag2_ = true;
                    break;
                }
            }

            //Вводим оператор
            System.Console.WriteLine("Введите операцию: *, /, +, -");
            operator_ = System.Console.ReadLine();

            //Определяем флаг, выбираем нужную цепь switch-case;

            if (flag1_ == false && flag2_ == false) // действия с целочисленными переменными
            {
                switch (operator_)
                {
                    case "+":
                        System.Console.WriteLine("результат: {0} ", Convert.ToInt64(arg_1) + Convert.ToInt64(arg_2));
                        break;
                    case "-":
                        System.Console.WriteLine("результат: {0} ", Convert.ToInt64(arg_1) - Convert.ToInt64(arg_2));
                        break;
                    case "*":
                        System.Console.WriteLine("результат: {0} ", Convert.ToInt64(arg_1) * Convert.ToInt64(arg_2));
                        break;
                    case "/":
                        System.Console.WriteLine("результат: {0} ", Convert.ToDouble(arg_1) / Convert.ToDouble(arg_2));
                        break;
                }
            }

            if (flag1_ == true && flag2_ == false || flag1_ == false && flag2_ == true || flag1_ == true && flag2_ == true)
            { //действия при смешанном типе данных 
                switch (operator_)
                {
                    case "+":
                        System.Console.WriteLine("результат: {0} ", Convert.ToDouble(arg_1.Replace('.', ',')) + Convert.ToDouble(arg_2.Replace('.', ',')));
                        break;
                    case "-":
                        System.Console.WriteLine("результат: {0} ", Convert.ToDouble(arg_1.Replace('.', ',')) - Convert.ToDouble(arg_2.Replace('.', ',')));
                        break;
                    case "*":
                        System.Console.WriteLine("результат: {0} ", Convert.ToDouble(arg_1.Replace('.', ',')) * Convert.ToDouble(arg_2.Replace('.', ',')));
                        break;
                    case "/":
                        System.Console.WriteLine("результат: {0} ", Convert.ToDouble(arg_1.Replace('.', ',')) / Convert.ToDouble(arg_2.Replace('.', ',')));
                        break;
                }
            }
            System.Console.WriteLine("Для выхода введите exit, для продолжения нажмите enter");
        }
    }
}
