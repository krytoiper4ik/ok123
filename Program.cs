
namespace практическая_3_консоль
{ 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер варианта (1-30):");
        int variant = int.Parse(Console.ReadLine());

        switch (variant)
        {
            case 1:
                Console.WriteLine("Вычисление для варианта 1");
                double a1 = 1.0, x1 = 2.0, c1 = 3.0;
                double L1 = Math.Sqrt(Math.Pow(Math.E, 2) - Math.Pow(Math.Cos(Math.Pow(x1, 2) + Math.Pow(a1, 2)), 3)) + Math.Pow(Math.Atan(a1 - Math.Pow(x1, 2)), 2);
                double e0 = Math.Sqrt(Math.Abs(a1 + x1 * c1));
                Console.WriteLine($"L = {L1}, e0 = {e0}");
                break;

            case 2:
                Console.WriteLine("Вычисление для варианта 2");
                double c2 = 1.0, x2 = 2.0, f2 = 3.0, t2 = 4.0;
                double L2 = Math.Pow(1 / Math.Tan(c2), 2) + (2 * Math.Pow(x2, 2) + 5) / Math.Sqrt(c2 + f2 * t2);
                Console.WriteLine($"L = {L2}");
                break;

            case 3:
                Console.WriteLine("Вычисление для варианта 3");
                double y3 = 1.0, h3 = 2.0;
                double A3 = (Math.Tan(Math.Pow(y3, 3) - Math.Pow(h3, 4)) + Math.Pow(h3, 2)) / (Math.Pow(Math.Sin(h3), 3) + y3);
                Console.WriteLine($"A = {A3}");
                break;

            case 4:
                Console.WriteLine("Вычисление для варианта 4");
                double y4 = 1.0, x4 = 2.0;
                double F4 = Math.Sqrt(Math.Pow(2 + y4, 2) + Math.Sqrt(Math.Sin(y4 + 5))) / (Math.Log(x4 + 1) - Math.Pow(y4, 3));
                Console.WriteLine($"F = {F4}");
                break;

            case 5:
                Console.WriteLine("Вычисление для варианта 5");
                double x5 = 1.0, z5 = 2.0, y5 = 3.0;
                double G5 = (Math.Tan(Math.Pow(x5, 4) - 6) - Math.Pow(Math.Cos(z5 + y5), 2)) / Math.Pow(Math.Cos(Math.Pow(x5, 2)), 4);
                Console.WriteLine($"G = {G5}");
                break;

            case 6:
                Console.WriteLine("Вычисление для варианта 6");
                double x6 = 1.0, b6 = 2.0, a6 = 3.0, y6 = 4.0;
                double K6 = (Math.Sqrt(x6 + b6 - a6) + Math.Log(y6)) / Math.Atan(b6 + a6);
                Console.WriteLine($"K = {K6}");
                break;

            case 7:
                Console.WriteLine("Вычисление для варианта 7");
                double x7 = 1.0, y7 = 2.0, a7 = 3.0;
                double D7 = (Math.Cos(Math.Pow(x7, 3) + 6) - Math.Sin(y7 - a7)) / (Math.Log(Math.Pow(x7, 2)) - 2 * Math.Pow(Math.Sin(x7), 2));
                Console.WriteLine($"D = {D7}");
                break;

            case 8:
                Console.WriteLine("Вычисление для варианта 8");
                double a8 = 1.0, y8 = 2.0, c8 = 3.0, x8 = 4.0;
                double P8 = (Math.Pow(a8, 3) + Math.Pow(Math.Sin(y8 - c8), 4)) / (Math.Pow(Math.Sin(x8 + y8), 3) + Math.Abs(x8 - y8));
                Console.WriteLine($"P = {P8}");
                break;

            case 9:
                Console.WriteLine("Вычисление для варианта 9");
                double y9 = 1.0, d9 = 2.0, x9 = 3.0;
                double R9 = (Math.Pow(Math.Cos(y9), 3) + Math.Pow(2, d9)) / (Math.Exp(y9) + Math.Log(Math.Pow(Math.Sin(x9), 2) + 7.4));
                Console.WriteLine($"R = {R9}");
                break;

            case 10:
                Console.WriteLine("Вычисление для варианта 10");
                double x10 = 1.0, y10 = 2.0;
                double U10 = (Math.Exp(x10) + Math.Pow(Math.Cos(x10 - 4), 2)) / (Math.Atan(x10) + 5.2 * y10);
                Console.WriteLine($"U = {U10}");
                break;

            case 11:
                Console.WriteLine("Вычисление для варианта 11");
                double y11 = 1.0, x11 = 2.0;
                double I11 = (2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(y11), 3)))) / (Math.Exp(y11) + Math.Pow(Math.Sin(x11), 2));
                Console.WriteLine($"I = {I11}");
                break;

            case 12:
                Console.WriteLine("Вычисление для варианта 12");
                double y12 = 1.0, x12 = 2.0, a12 = 3.0;
                double G12 = (Math.Pow(Math.Cos(y12), 3) + 4 - (x12 + y12)) / (Math.Pow(Math.Atan(x12 + a12), 2) * Math.Pow(x12, 5));
                Console.WriteLine($"G = {G12}");
                break;

            case 13:
                Console.WriteLine("Вычисление для варианта 13");
                double a13 = 1.0, x13 = 2.0, b13 = 3.0;
                double R13 = a13 / (x13 - a13) + (Math.Pow(b13, x13) + Math.Pow(Math.Cos(x13), 3)) / (Math.Pow(Math.Log10(a13), 4) + 4.5);
                Console.WriteLine($"R = {R13}");
                break;

            case 14:
                Console.WriteLine("Вычисление для варианта 14");
                double x14 = 1.0;
                double R14 = (Math.Pow(Math.Sin(Math.Pow(x14, 2) + 4), 2) + 4.3) / Math.Pow(Math.Sin(Math.Pow(x14, 4)), 3);
                Console.WriteLine($"R = {R14}");
                break;

            case 15:
                Console.WriteLine("Вычисление для варианта 15");
                double m15 = 1.0, y15 = 2.0;
                double N15 = (Math.Pow(m15, 2) + 2.8 * m15 + 0.355) / (Math.Cos(2 * y15) + 3.6);
                Console.WriteLine($"N = {N15}");
                break;

            case 16:
                Console.WriteLine("Вычисление для варианта 16");
                double x16 = 1.0, y16 = 2.0, t16 = 3.0;
                double P16 = (Math.Pow(Math.Sin(x16), 3) + Math.Log(2 * y16 + 3 * x16)) / (Math.Pow(t16, 2) + Math.Sqrt(x16));
                Console.WriteLine($"P = {P16}");
                break;

            case 17:
                Console.WriteLine("Вычисление для варианта 17");
                double x17 = 1.0, b17 = 2.0, a17 = 3.0, y17 = 4.0;
                double T17 = (Math.Sqrt(x17 + b17 - a17) + Math.Log(y17)) / Math.Atan(b17 + a17);
                Console.WriteLine($"T = {T17}");
                break;

            case 18:
                Console.WriteLine("Вычисление для варианта 18");
                double y18 = 1.0, t18 = 2.0;
                double S18 = (4.351 * Math.Pow(y18, 3) + 2 * t18 * Math.Log(t18)) / (Math.Cos(2 * y18) + 4.351);
                Console.WriteLine($"S = {S18}");
                break;

            case 19:
                Console.WriteLine("Вычисление для варианта 19");
                double K19 = 1.0, a19 = 2.0, b19 = 3.0, x19 = 4.0, y19 = 5.0;
                double D19 = (Math.Pow(K19, -a19 / 6) - Math.Cos(3 * a19 * b19)) / Math.Pow(Math.Sin(a19 - Math.Asin(x19) + Math.Log(y19)), 2);
                Console.WriteLine($"D = {D19}");
                break;

            case 20:
                Console.WriteLine("Вычисление для варианта 20");
                double y20 = 1.0, x20 = 2.0, b20 = 3.0, c20 = 4.0, a20 = 5.0;
                double U20 = (Math.Pow(Math.Tan(y20), 3) + Math.Pow(Math.Sin(x20), 3) * Math.Sqrt(b20 - c20)) / Math.Sqrt(a20 - b20 + c20);
                Console.WriteLine($"U = {U20}");
                break;

            case 21:
                Console.WriteLine("Вычисление для варианта 21");
                double z21 = 1.0, x21 = 2.0, a21 = 3.0;
                double N21 = Math.Pow(z21 + Math.Sqrt(x21), 1.0 / 3) / (Math.Exp(2) + Math.Pow(a21, 2) * Math.Atan(x21));
                Console.WriteLine($"N = {N21}");
                break;

            case 22:
                Console.WriteLine("Вычисление для варианта 22");
                double x22 = 1.0, y22 = 2.0;
                double F22 = Math.Cos(Math.Pow(x22, 2) + 2) + (3.5 * Math.Pow(x22, 2) + 1) / Math.Pow(Math.Cos(y22), 3);
                Console.WriteLine($"F = {F22}");
                break;

            case 23:
                Console.WriteLine("Вычисление для варианта 23");
                double x23 = 1.0, z23 = 2.0, b23 = 3.0, a23 = 4.0;
                double F23 = (Math.Sqrt(Math.Abs(x23) + Math.Pow(Math.Cos(x23), 3) + Math.Pow(z23, 4))) / (Math.Log(x23) - Math.Asin(b23 * x23 - a23));
                Console.WriteLine($"F = {F23}");
                break;

            case 24:
                Console.WriteLine("Вычисление для варианта 24");
                double b24 = 1.0, x24 = 2.0, a24 = 3.0, z24 = 4.0;
                double f24 = (Math.Pow(Math.Cos(b24 * Math.Pow(x24, 2)), 3) - (Math.Sin(Math.Pow(a24, 2)) + Math.Cos(Math.Pow(x24, 2) + Math.Pow(z24, 2) - Math.Pow(a24, 2)))) / (Math.Asin(Math.Pow(a24, 2)) + Math.Acos(Math.Pow(x24, 2) - Math.Pow(a24, 2)));
                Console.WriteLine($"f = {f24}");
                break;

            case 25:
                Console.WriteLine("Вычисление для варианта 25");
                double a25 = 1.0, y25 = 2.0, x25 = 3.0;
                double J25 = (Math.Pow(1 / Math.Tan(Math.Pow(a25, 3)), 2) + Math.Pow(Math.Atan(a25), 2)) / Math.Sqrt(Math.Pow(y25, 4) * x25);
                Console.WriteLine($"J = {J25}");
                break;

            case 26:
                Console.WriteLine("Вычисление для варианта 26");
                double x26 = 1.0, y26 = 2.0, k26 = 3.0;
                double U26 = (Math.Log(Math.Pow(x26, 3) + y26) - Math.Pow(y26, 4)) / (Math.Exp(y26) + 5.4 * Math.Pow(k26, 3));
                Console.WriteLine($"U = {U26}");
                break;

            case 27:
                Console.WriteLine("Вычисление для варианта 27");
                double a27 = 1.0, x27 = 2.0, y27 = 3.0, c27 = 4.0;
                double P27 = (Math.Pow(a27, 2) + Math.Acos(a27 + x27) - Math.Pow(Math.Sin(y27 - c27), 4)) / (Math.Pow(Math.Sin(x27 + y27), 3) + Math.Abs(x27 - y27));
                Console.WriteLine($"P = {P27}");
                break;

            case 28:
                Console.WriteLine("Вычисление для варианта 28");
                double x28 = 1.0, z28 = 2.0, y28 = 3.0;
                double G28 = (Math.Tan(Math.Pow(x28, 4) - 6) - Math.Pow(Math.Cos(z28 + Math.Pow(x28, 3) * y28), 3)) / Math.Pow(Math.Cos(Math.Pow(x28, 2)), 4);
                Console.WriteLine($"G = {G28}");
                break;

            case 29:
                Console.WriteLine("Вычисление для варианта 29");
                double y29 = 1.0, d29 = 2.0, x29 = 3.0;
                double R29 = (Math.Pow(Math.Cos(y29), 2) + 2.4 * d29) / (Math.Exp(y29) + Math.Log(Math.Pow(Math.Sin(x29), 2) + 6));
                Console.WriteLine($"R = {R29}");
                break;

            case 30:
                Console.WriteLine("Вычисление для варианта 30");
                double x30 = 1.0, b30 = 2.0;
                double K30 = Math.Sqrt(Math.Pow(3 + x30, 2) - Math.Log(x30)) / (Math.Exp(3) + Math.Asin(b30 * Math.Pow(x30, 2)));
                Console.WriteLine($"K = {K30}");
                break;

            default:
                Console.WriteLine("Неверный номер варианта.");
                break;
        }
    }
}
}