namespace T13_01_02_HomeworkAdvancedExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Console Application that throws an exception
            //in a method that you catch in the main method.

            try
            {
                CreateException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("------------------------------------");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static void CreateException()
        {
            Console.WriteLine("2 + 2 = 5");
            throw new ArithmeticException("Something is wrong with this method.");
        }
    }
}