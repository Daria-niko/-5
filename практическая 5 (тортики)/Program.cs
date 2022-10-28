using System.Diagnostics;

namespace практическая_5__тортики_
{
    internal class Program
    {

        static void Main()
        {

            cake_created cake_Created = new cake_created();
            int position = 3;

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                cake_Created.Menu();
                //bool proverka = true;
                position = cake_Created.Arrow(position, key);


                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    if (position == 3)
                    {
                        Console.WriteLine("Выберите форму тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Forma());
                        
                    }
                    else if (position == 4)
                    {
                        Console.WriteLine("Выберите размер тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Size());
                        
                    }
                    else if (position == 5)
                    {

                        Console.WriteLine("Выберите вкус тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Taste());
                    }
                    else if (position == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите количество коржей в тортике");
                        cake_Created.Output_Pod_Menu(cake_Created.Korge());
                    }
                    else if (position == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите вкус глазури");
                        cake_Created.Output_Pod_Menu(cake_Created.Glasure());
                    }
                    else if (position == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите декор тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Dekor());
                    }
                    else if (position == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("Спасибо за заказ! \n Нажмите Esc, что-бы заказать еще тортик");
                        cake_Created.Save();

                        if (key == ConsoleKey.Escape)
                        {
                            cake_Created.Menu();
                            cake_Created.ClearOrder();
                        }

                    }
                }
            }
        }
    }
}
