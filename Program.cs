using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_7
{
    class Program

    {
        struct Complex
        {
            public double Re; //действительная часть
            public double Im;//мнимая часть

            //Конструктор
            public Complex (double re, double im)
            {
                this.Re = re;
                this.Im = im;
            }

            //Методы
            public Complex Addition (Complex a, Complex b)
            {
                return new Complex(a.Re + b.Re, a.Im + b.Im);
            }
            public Complex Substraction(Complex a, Complex b)
            {
                return new Complex(a.Re - b.Re, a.Im - b.Im);
            }

            public Complex Multiplication(Complex a, Complex b)
            {
                double Res_Re = a.Re * b.Re - a.Im * b.Im;
                double Res_Im = a.Re * b.Im + a.Im * b.Re;
                return new Complex(Res_Re, Res_Im);
            }
            public Complex Partion(Complex a, Complex b)
            {
                double Res_Re = (a.Re * b.Re + a.Im * b.Im) / (b.Re * b.Re + b.Im * b.Im);
                double Res_Im = (b.Re * a.Im - a.Re * b.Im) / (b.Re * b.Re + b.Im * b.Im);
                return new Complex(Res_Re, Res_Im);
            }
            public override string ToString()
            {
                return $" ({Re} + {Im}i)";
            }
        }
        static void Main(string[] args)
        {
            Complex a, b;
            Console.WriteLine("Введите действительную часть комплексного числа 1: ");
            a.Re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действительную часть мнимую числа 1: ");
            a.Im = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действительную часть комплексного числа 2: ");
            b.Re = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действительную часть мнимую числа 2: ");
            b.Im = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"ВЫ ввели первое число {a} и второе число {b} ");

            Complex res = new Complex();
            res = res.Addition(a,b);
            Console.WriteLine($"Результат сложения комплексных чисел: {res} ");
            res = res.Substraction(a, b);
            Console.WriteLine($"Результат вычитания комплексных чисел: {res} ");
            res = res.Multiplication(a, b);
            Console.WriteLine($"Результат умножения комплексных чисел: {res} ");
            res = res.Partion(a, b);
            Console.WriteLine($"Результат деления комплексных чисел: {res} ");
        }
    }
}
