namespace T14_DebuggingMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = W(0);
            try
            {
                //int i = W(0);
                //int i = W(1);
                double i = W(1);
                Console.WriteLine(i);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(ex.Message);
            }

            //Console.ReadLine();
        }

        //private static int W(int e)
        private static double W(double e)
        {
            //int n = 1;
            double n = 1;
            n = J(e) + 4;
            return n;
        }

        //private static int P(int v)
        private static double P(double v)
        {
            //int o = 0;
            double o = 0;
            o = F(v) + 2;
            return o;
        }

        //private static int F(int x)
        private static double F(double x)
        {
            //int y = 0;
            double y = 0;
            y = x / 5;
            return y;
        }

        //private static int J(int a)
        private static double J(double a)
        {
            //int c = 0;
            double c = 0;
            a = a - 1;
            c = R(a);
            c = P(c) / 3;
            return c;
        }

        //private static int R(int v)
        private static double R(double v)
        {
            //int z = 5;
            double z = 5;

            //z = 3 / v;
            if (v == 0)
            {
                throw new ArgumentException("Cannot divide by zero.", nameof(v));
            }
            else
            {
                z = 3 / v;
            }

            //return v;
            return z;
        }
    }
}