namespace T13_01_01_AdvancedExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name = "";

            try
            {
                DifferentMethod();

                Console.Write("What is your name? ");
                name = Console.ReadLine();
                ComplexMethod(name);

                SimpleMethod();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling thees methods.");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("You forgot to finish your code.");
            }
            catch (Exception) when (name?.ToLower() == "tim")
            {
                Console.WriteLine("You used Tim's name, didn't you?");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I always run.");
            }
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("This is the different method now working properly.");
            //throw new NotImplementedException();
        }

        private static void ComplexMethod(string? name)
        {
            if (name?.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is to tall for this method.");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim.");
            }
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod.");
        }
    }
}