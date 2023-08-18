namespace T12_01_02_HomeworkStepThroughTheForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Console Application with a for loop that multiplies a
            // number by five and adds it ti the total each time.
            // Step through the code.

            int total = 0;

            for (int i = 1; i < 10; i++)
            {
                total += i * 5;
            }

            Console.WriteLine(total);
        }
    }
}