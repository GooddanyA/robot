using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main()

        {
            Console.WriteLine("Добро пожаловать!");
            while(true)
            {
                //
                Random rnd = new Random();
                int value = rnd.Next(0, 8);
                Game(value);
                Console.WriteLine(" Может еще раз??? ");
                string g = Console.ReadLine();
                switch (g)
                {
                    case "Да":

                        break;
                    case "Нет":
                        return;

                }

            }
           

        }



        public static void Game(int value)
        {
            int i = 0;
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine($"Введите ваше число (попытка {i+1})");
               
                    {
                        int count = int.Parse(Console.ReadLine());





                        if (count < value)
                        {
                            Console.WriteLine("Ваше число должно быть больше");
                        }
                        if (count > value)
                        {
                            Console.WriteLine("Ваше число должно быть меньше");
                        }
                        if (count == value)
                        {
                            Console.WriteLine("Вы угадали!!!");
                        return;
                           
                        }


                }

            }
        }
    }
}


           