using System;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            if (a > 0 && b > 0)
            {
                answer = true;
            }
            else if (a < 0 && b < 0)
            {
                answer = true;
            }

            return answer;
        }
        public bool Task2(double d)
        {
            d = d % 1;
            d = Math.Abs(d);
            bool answer = false;
            if (d != 0)
            {
                answer = true;
            }
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (b!=0 && a%b==0)
            {
                answer = true;
            }

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            double d1 = Math.Abs(d);
            double f1 = Math.Abs(f);
            double g1 = Math.Abs(g);
            if (d1 > f1 && d1 > g1)
            {
                answer = d;
            }
            else if ( f1 > d1 && f1 > g1)
            {
                answer = f;
            }
            else if (g1 > d1 && g1 > f1)
            {
                answer = g;
            }
            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <=-1)
            {
                answer = 0;
            }
            else if (x > -1 && x <=0)
            {
                answer = x + 1;
            }
            else if (x > 0)
            {
                answer = 1;
            }
            answer = Math.Round(answer, 2);
            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;
            double pi = 3.1416;

            double r2 = circleS / pi;
            double r = Math.Pow(r2, 0.5);
            double squarer = Math.Pow(squareS, 0.5);
            if (squarer >= r*2)
            {
                answer = true;
            }
            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;
            int a1 = a / 2;
            int b1 = b / 2;
            int c1 = c / 2;
            int sm = a1 + b1 + c1;
            int sm1 = a1 + b1 + c1+1;
            if ((sm >= 3 && sm % 3 == 0) || (sm1 >= 3 && sm1 % 3 == 0))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                return answer;
        }
    }
}


