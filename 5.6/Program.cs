using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    class Program
    {
        static (string Name, string LastName, int Age, int CountPet, int CountColor) EnterUser()
        {
            (string Name, string LastName, int Age, int CountPet, int CountColor) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            string CheckPet;
            string age;
            int intage;
            int CountPet;
            string CountPets;
            int CountColors;
            string ColCount;
            string[] NamePets;
            string[] colors;

            do
            {
                Console.WriteLine("Введите возраст");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));
            Console.WriteLine("У вас есть питомец? да или нет");
            CheckPet = Console.ReadLine();
            switch (CheckPet)
            {
                case "да":
                    do
                    {
                        Console.WriteLine("Сколько у вас питомцев?");
                        CountPets = Console.ReadLine();
                    }
                    while (CheckNum(CountPets, out CountPet));

                    NamePets = new string[CountPet];

                    for (int i = 0; i < int.Parse(CountPets); i++)
                    {
                        Console.WriteLine("Введите кличку вашего {0} питомца", i + 1);
                        NamePets[i] = Console.ReadLine();
                    }
                    break;

                default:
                    CountPet = 0;
                    NamePets = default;
                    break;
            }
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");
                ColCount = Console.ReadLine();
            }
            while (CheckNum(ColCount, out CountColors));

            colors = new string[CountColors];

            for (int i = 0; i < CountColors; i++)
            {
                Console.WriteLine("Введите ваш {0} любимый цвет", i + 1);
                colors[i] = Console.ReadLine();
            }

            User.CountColor = CountColors;
            User.Age = intage;
            User.CountPet = CountPet;

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Вас зовут " + User.Name);
            Console.WriteLine("Ваша фамилия " + User.LastName);
            Console.WriteLine("Вам уже " + User.Age);
            Console.WriteLine("У вас {0} питомца", User.CountPet);

            for (int i = 0; i < CountPet; i++)
            {
                Console.WriteLine("Их зовут: " + NamePets[i]);
            }
            Console.WriteLine("У вас {0} любимых цвета", CountColors);

            for (int i = 0; i < CountColors; i++)
            {
                Console.WriteLine("Это: " + colors[i]);
            }

            return User;
        }
        static bool CheckNum(string number, out int corrnumber)
        {
            if(int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            }
        }
        static void Main(string[] args)
        {
            EnterUser();
            Console.ReadLine();
        }



    }
}
