namespace Lexicon_övning5
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");



            ConsoleUI consoleUI = new ConsoleUI();


            consoleUI.NewGarage();



            while (true)
            {


                consoleUI.DisplayMenu();

                char input = consoleUI.GetUserInput()[0];


                switch (input)
                {
                    case '1':
                        consoleUI.PopulateGarage();
                        break;
                    case '2':
                        consoleUI.ListAllVehicles();
                        break;
                    case '3':

                        break;
                    case '4':
                        consoleUI.AddVehicle();
                        break;
                    case '5':
                        consoleUI.RemoveVehicle();
                        break;
                    case '6':
                        consoleUI.FindVehicle();
                        break;
                    case '7':

                        break;
                    case '8':
                        consoleUI.NewGarage();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }

                //Console.Clear();
            }

        }



    }
}
