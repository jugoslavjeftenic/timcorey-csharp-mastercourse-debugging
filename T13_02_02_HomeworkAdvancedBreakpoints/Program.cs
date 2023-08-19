namespace T13_02_02_HomeworkAdvancedBreakpoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Console Application that loops from 1 to 100.
            // Throw an exception on 73.
            // Use a breakpoint to break before the breaking situation.

            for (int i = 1; i <= 100; i++)
            {
                if (i == 73)
                {
                    throw new Exception();
                }
            }
        }
    }
}