

// Rasmus Glasell Johansson SUT23



namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool program = true;

            while (program)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Välkommen till Numbers Game!");
                    Console.WriteLine("[1] Spela spelet: ");
                    Console.WriteLine("[2] Avsluta programmet: ");
                    int menuChoice = Convert.ToInt32(Console.ReadLine());

                    switch (menuChoice)
                    {
                        case 1:
                            try
                            {
                                NumbersGame();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                            }

                            break;
                        case 2:
                            Console.WriteLine("Programmet avslutas!");
                            Console.ReadKey();
                            program = false;
                            break;
                        default:
                            Console.WriteLine("OBS! Svara med 1 eller 2.");
                            Console.ReadKey();
                            break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }                
            }           
        }
        static void NumbersGame()
        {
            Random random = new Random();
            int number = random.Next(1, 20);


            Console.WriteLine("Välkommen! \nJag tänker på ett tal mellan 1 och 20." +
                                  " Kan du gissa vilket?\nDu får 5 försök.");
            for (int i = 5; i > 0; i--)
            {
                Console.Write("Gissa på ett tal: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Grattis! Du gissade rätt!");
                    Console.ReadKey();
                    break;
                }
                else if (guess != number && i == 1)
                {
                    Console.WriteLine("Tyvärr! Du lyckades inte. . .");
                    Console.WriteLine($"Rätt svar var {number}.");
                    Console.ReadKey();
                }
                else if (guess < number)
                {
                    Console.WriteLine("Du gissade för lågt!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Du gissade för högt");
                }
                Console.WriteLine($"Du har {i - 1} gissningar kvar.");
            }
        }
    }
}