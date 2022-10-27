using System.Diagnostics;

namespace практическая_5__тортики_
{
    internal class Program
    {
        public static  int cost;
        public static string zakaz;
        static void Main()
        {

            cake_created cake_Created = new cake_created();
            int position = 3;
            cost = 0;
            zakaz = "";

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                cake_Created.Menu();
                //bool proverka = true;
                position = cake_Created.Arrow(position, key);


                if (key == ConsoleKey.Enter)
                {
                    ConsoleKey key1 = Console.ReadKey().Key;
                    if (position == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите форму тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Forma());
                        if (key1 == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;
                        }
                        else if(key1 == ConsoleKey.F1)
                        {
                            if (position == 0)
                            {
                                cost = cost + 10;
                            }
                            else if (position == 1)
                            {
                                cost = cost + 15;
                            }
                            else if (position == 2)
                            {
                                cost = cost + 20;
                            }

                        }
                    }
                    else if (position == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите размер тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Size());
                        if (key1 == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (position == 5)
                    {

                        Console.Clear();
                        Console.WriteLine("Выберите вкус тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Taste());
                        if (key1 == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;
                        }

                    }
                    else if (position == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите количество коржей в тортике");
                        cake_Created.Output_Pod_Menu(cake_Created.Korge());
                        if (key1 == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (position == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите вкус глазури");
                        cake_Created.Output_Pod_Menu(cake_Created.Glasure());
                        if (key1 == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (position == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите декор тортика");
                        cake_Created.Output_Pod_Menu(cake_Created.Dekor());
                        if (key1 == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (position == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("Спасибо за заказ! \n Нажмите Esc, что-бы заказать еще тортик");


                    }
                }
            }
        }


    }
}
