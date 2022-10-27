
using System.Security.Cryptography;

namespace практическая_5__тортики_
{
    internal class cake_created
    {

        

        public void Menu()
        {
            Console.WriteLine("Добро пожаловать в магазин ТОРТИКИ НА ЛЮБОЙ ВКУС");
            Console.WriteLine("Выберете параметр торта");
            Console.WriteLine("======================");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Заказ завершен");
            Console.WriteLine("======================");
            Console.WriteLine("Цена: " + Program.cost);
            Console.WriteLine("Ваш заказ: " + Program.zakaz);
        }

        public List<PodMenu> Forma()
        {
            PodMenu krug = new PodMenu();
            krug.title = "Круг";
            krug.price = 10;
            PodMenu serdechko = new PodMenu();
            serdechko.title = "Сердешко";
            serdechko.price = 15;
            PodMenu kvadrat = new PodMenu();
            kvadrat.title = "Квадрат";
            kvadrat.price = 20;

            List<PodMenu> forma = new List<PodMenu>();
            forma.Add(krug);
            forma.Add(serdechko);
            forma.Add(kvadrat);

            return forma;
        }
        public List<PodMenu> Size()
        {
            PodMenu big = new PodMenu();
            big.title = "Большой";
            big.price = 500;
            PodMenu medile = new PodMenu();
            medile.title = "Средний";
            medile.price = 300;
            PodMenu small = new PodMenu();
            small.title = "Маленький";
            small.price = 100;

            List<PodMenu> size = new List<PodMenu>();
            size.Add(big);
            size.Add(medile);
            size.Add(small);

            return size;
        }
        public List<PodMenu> Taste()
        {
            PodMenu rasp = new PodMenu();
            rasp.title = "Малиновыйй";
            rasp.price = 250;
            PodMenu straw = new PodMenu();
            straw.title = "Клубничный";
            straw.price = 150;
            PodMenu coffee = new PodMenu();
            coffee.title = "Кофейный";
            coffee.price = 100;

            List<PodMenu> taste = new List<PodMenu>();
            taste.Add(rasp);
            taste.Add(straw);
            taste.Add(coffee);

            return taste;
        }
        public List<PodMenu> Korge()
        {
            PodMenu onek = new PodMenu();
            onek.title = "1 корж";
            onek.price = 200;
            PodMenu twok = new PodMenu();
            twok.title = "2 коржа";
            twok.price = 300;
            PodMenu trek = new PodMenu();
            trek.title = "3 коржа";
            trek.price = 500;

            List<PodMenu> korge = new List<PodMenu>();
            korge.Add(onek);
            korge.Add(twok);
            korge.Add(trek);

            return korge;
        }
        public List<PodMenu> Glasure()
        {
            PodMenu vanile = new PodMenu();
            vanile.title = "Ванильный";
            vanile.price = 100;
            PodMenu choko = new PodMenu();
            choko.title = "Шоколадная";
            choko.price = 200;
            PodMenu bese = new PodMenu();
            bese.title = "Безе";
            bese.price = 300;

            List<PodMenu> glasure = new List<PodMenu>();
            glasure.Add(vanile);
            glasure.Add(choko);
            glasure.Add(bese);

            return glasure;
        }
        public List<PodMenu> Dekor()
        {
            PodMenu berry = new PodMenu();
            berry.title = "Ягоды";
            berry.price = 500;
            PodMenu figure = new PodMenu();
            figure.title = "Фигурки";
            figure.price = 200;
            PodMenu podteki = new PodMenu();
            podteki.title = "Подтеки";
            podteki.price = 300;

            List<PodMenu> glasure = new List<PodMenu>();
            glasure.Add(berry);
            glasure.Add(figure);
            glasure.Add(podteki);

            return glasure;
        }

        public void Output_Pod_Menu(List<PodMenu> box)
        {
            int position = 1;
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                foreach (PodMenu podmenu in box)
                {
                    Console.WriteLine("  " + podmenu.title + " - " + podmenu.price);
                }
                position = Arrow(position, key);
                if(key == ConsoleKey.Enter)
                {

                    return;
                }
            }
        }
        public int Arrow(int position, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.DownArrow:
                    position++;
                   
                    break;
                case ConsoleKey.UpArrow:
                    position--;
                    break;
            }
            

            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            return position;
        }

    }
}
