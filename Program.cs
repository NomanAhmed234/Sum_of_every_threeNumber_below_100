namespace Lab_3d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2, sum=2;
            do
            {
                sum = sum + 3;
                i++;
            } while (i < 100);
            Console.WriteLine("Sum of every third integer beginning from 1 to 100 is {0}.",sum);

        }
    }
}