namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favnumber = 42;
            Console.WriteLine("Guess my favorite number: ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput > favnumber)
            {
                Console.WriteLine("Too high!");
            }
            else if (userInput < favnumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }
        }
    }
}
