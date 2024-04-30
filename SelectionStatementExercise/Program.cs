namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            // The following code will allow the user to guess what your favorite number is
            // (be sure to prompt the user what to input):
            Console.WriteLine("Try to guess my favorite number?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low!");
            } else if(userInput > favNumber)
            {
                Console.WriteLine("Too high.");
            } else
            {
                Console.WriteLine("You got it!");
            }


            //Exercise 2

            Console.WriteLine("What was you favorite subject in school?");
            var subject = Console.ReadLine();

            switch(subject)
            {
                case "History":
                    Console.WriteLine("I liked history too!");
                    break;
                case "Math":
                    Console.WriteLine("Math was good.");
                    break;
                case "English":
                    Console.WriteLine("That was my favorite too!");
                    break;
                case "Biology":
                    Console.WriteLine("Nope. That was way too much for me.");
                    break;
                default:
                    Console.WriteLine("That was a good one. My favorite was history."):
                        break;
            }
        }
    }
}
