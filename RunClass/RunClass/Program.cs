namespace RunClass
{
    internal class Program {
        static void Main(string[] args) {

            Hello hello = new Hello();

            hello.Hi();

        }
    }
    internal class Hello {
         internal void Hi() {
            Console.WriteLine("Hi!");
        }
    }
}
