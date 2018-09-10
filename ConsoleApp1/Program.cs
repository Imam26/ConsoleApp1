using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private struct Body
        {
            public Body(int M, int V) { m = M; v = V; }
            public int m;
            public int v;
        }
        private struct ElectricalCircuit
        {
            public ElectricalCircuit(int R, int U) { r = R; u = U; }
            public int r;
            public int u;
        }
        static void Main(string[] args)
        {
            Console.Write("1) "); ShowNumberWithSpace();
            Console.WriteLine("2) "); ShowNumberUnder();
            Console.WriteLine("3) {0} см = {1} м", 1000, SantimToMetr(1000));
            Console.WriteLine("4) {0} дней = {1} недель", 234, DayToWeek(234));
            Console.Write("5) "); TwoDigitNumber(37);
            Console.WriteLine("6) ");TrueOrFalse();
            Console.WriteLine("7) ");ShowBiggerSquare(7,7);
            Console.WriteLine("8) ");ShowBiggerDensity(new Body(5, 10), new Body(7, 20));
            Console.WriteLine("9) ");ShowLowerCurrent(new ElectricalCircuit(4, 220), new ElectricalCircuit(5, 220));
            Console.WriteLine("10) ");PrintNumberInColumn();
        }
        static void ShowNumberWithSpace() //1.
        {
            Console.WriteLine("{0}  {1}  {2}",1,2,3);
        }
        static void ShowNumberUnder() //2.
        {
            Console.WriteLine("{0}\n{1}\n{2}", 5,10,21);
        }
        static double SantimToMetr(int santim)//3.
        {
            return santim / 100.0;
        }
        static int DayToWeek(int day)//4.
        {
            return day / 7;
        }
        static void TwoDigitNumber(int num)//5.
        {
            Console.WriteLine("Число - {0}", num);
            Console.WriteLine("Число десятков: {0}", num/10);
            Console.WriteLine("Число единиц: {0}", num % 10);
            Console.WriteLine("Сумма цифр: {0}", num % 10+num/10);
            Console.WriteLine("Произведение цифр: {0}", (num % 10)*(num/10));
        }
        static void TrueOrFalse()//6
        {
            bool A = true;
            bool B = false, C = false;
            Console.WriteLine("A или B = {0}", A||B);
            Console.WriteLine("A и B = {0}", A&&B);
            Console.WriteLine("B или C = {0}", B || C);
        }
        static void ShowBiggerSquare(int radiusCrcl, int sideSq)//7
        {
            double sCrcl = 3.14d * radiusCrcl * radiusCrcl;
            double sSq = sideSq * sideSq;
            Console.WriteLine("Радиус круга - {0}, площадь - {1}", radiusCrcl, sCrcl);
            Console.WriteLine("Сторона квадрата - {0}, площадь - {1}", sideSq, sSq);
            Console.WriteLine(sSq > sCrcl ? "Площадь круга < Площадь квадрата": "Площадь круга > Площадь квадрата");
        }
        static void ShowBiggerDensity(Body one, Body two)//8
        {
            double p1 = ((one.m)+0.0) / one.v;
            double p2 = ((two.m) + 0.0) / two.v;
            Console.Write("p1 = {0} кг/м3, p2 = {1} кг/м3, ", p1,p2);
            if (p1 > p2) Console.WriteLine("p1>p2");
            else if (p1 < p2) Console.WriteLine("p1<p2");
            else Console.WriteLine("p1 = p2");
        }
        static void ShowLowerCurrent(ElectricalCircuit one, ElectricalCircuit two)//9
        {
            double i1 = ((one.u) + 0.0) / one.r;
            double i2 = ((two.u) + 0.0) / two.r;
            Console.Write("Цепь 1: i = {0} A. Цепь 2: i = {1} A, ", i1, i2);
            if (i1 > i2) Console.WriteLine("По цепи 2 протекает меньший ток");
            else if (i1 < i2) Console.WriteLine("По цепи 1 протекает меньший ток");
            else Console.WriteLine("Силы тока цепей равны");
        }
        static void PrintNumberInColumn()//10.
        {
            Console.WriteLine("a)");
            for(int i = 25; i<35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("b)");
            Console.Write("Введите значение b(b>10): ");
            string str;
            str = Console.ReadLine();
            for (int i = 10; i < int.Parse(str); i++)
            {
                Console.WriteLine(i*i);
            }
            Console.WriteLine("c)");
            Console.Write("Введите значение a(a<50): ");
            str = Console.ReadLine();
            for (int i = int.Parse(str); i < 50; i++)
            {
                Console.WriteLine(Math.Pow(i,3));
            }
            Console.WriteLine("d)");
            Console.Write("Введите значение а: ");
            string s = Console.ReadLine();
            Console.Write("Введите значение b(b>a): ");
            str = Console.ReadLine();
            for(int i = int.Parse(s); i< int.Parse(str); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
