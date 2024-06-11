namespace AverageOfArray
{
    internal class Program {
        static void Main(string[] args) {

            int[] scores = { 97, 92, 87, 88 };

            int sum = 0;

            sum = sum + scores[0];
            sum = sum + scores[1];
            sum = sum + scores[2];
            sum = sum + scores[3];

            Console.WriteLine($"The sum is {sum}.");

            decimal avg = 0;

            avg = sum / 4.0m;

            Console.WriteLine($"The average is {avg}.");
          
        }
    }
}
