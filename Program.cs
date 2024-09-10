
namespace IntroductionInLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input lenth of array ");
            int lengthOfArrey =Convert.ToInt32(Console.ReadLine());
            int[] number = new int[lengthOfArrey];

            Random random = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(-number.Length, number.Length);
            }

            var arrayNumber =string.Join(", ", number);
            Console.WriteLine($"You array is {arrayNumber}");

            int sumNumber = number.Sum();
            Console.WriteLine($"Sum of numbers in your array is {sumNumber}");

            List<int> listOfNumber = new List<int>() { };
            listOfNumber.AddRange(number);
            var sortNumber = listOfNumber.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", sortNumber));
        }
    }
}
