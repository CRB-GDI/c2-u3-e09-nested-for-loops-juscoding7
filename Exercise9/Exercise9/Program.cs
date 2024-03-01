namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int starw = 0;
            int starh = 0;
            int starw2 = 0;
            int starrow = starw2;

            Console.Write("What do you want as a width? ");
            int widthnumberpicked = int.Parse(Console.ReadLine());

            Console.Write("What do you want as the height? ");
            int heightnumberpicked = int.Parse(Console.ReadLine());



            for (starh = 1; starh < heightnumberpicked; starh++)
            {
                Console.Write("*");

                for (starw = 1; starw < widthnumberpicked; starw++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


            Console.Write("Pick the second width: ");
            int widthnumberpicked2 = int.Parse(Console.ReadLine());





            for (starrow = 0; starrow < widthnumberpicked2; starrow++)
            {



                for (starw2 = 0; starw2 <= starrow; starw2++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}