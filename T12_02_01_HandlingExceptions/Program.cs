namespace T12_02_01_HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine("We have a problem.");
                Console.WriteLine(ex.Message);
            }
        }

        private static void BadCall()
        {
            int[] ages = { 1, 3, 5 };

            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Houston, we have a problem.");
                    Console.WriteLine(ex);
                    throw new Exception("Error handling array.", ex);
                }
            }
        }
    }
}