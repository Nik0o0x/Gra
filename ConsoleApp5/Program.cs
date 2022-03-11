class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 10;
        int guess;
        int number;
        int guesses;
        String response;

        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("zgadnij liczbe pomiędzy " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" zgadnij: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " liczba jest za duża!");

                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " liczba jest za mała!");
                }
                guesses++;
            }
            Console.WriteLine("liczba: " + number);
            Console.WriteLine("Wygrałeś!!!");
            Console.WriteLine("trafienia: " + guesses);

            Console.WriteLine("chcesz grać jeszcze raz (T/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "T")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

            Console.WriteLine("dzięki za gre");
            Console.ReadKey();
        }

    }

}