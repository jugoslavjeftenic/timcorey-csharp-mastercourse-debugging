namespace T12_02_02_HomeworkHandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Console Application with a for loop that
            // throws an exception after five iterations.
            // Catch the exception.

            try
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(i);
                    if (i == 5)
                    {
                        throw new Exception("Thrown exception.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}