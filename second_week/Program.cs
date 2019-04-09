using System;
using System.Collections.Generic;

namespace RefuelingSt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fuel> fuels = new List<Fuel>();
            FuelStation fuelStation = new FuelStation
            {
                Fuels = fuels
            };
            fuelStation.Password = "FuelStation";

            string ch;
            do
            {
                Console.Clear();
                Console.WriteLine("********Меню********\n" +
                "1.Покупатель\n" +
                "2.Администратор\n" +
                "3.Выход");

                ch = Console.ReadLine();

                switch (ch)
                {
                    case "1":
                        {
                            Console.Clear();
                            fuelStation.PriceList(fuels);

                            Console.WriteLine("\nВведите номер марки бензина\n");
                            fuelStation.ShowNameFuel(fuels);
                            
                            int name_mark = Convert.ToInt32(Console.ReadLine());
                                if (name_mark < fuels.Count)
                                {

                                    Console.WriteLine("Введите количество бензина(л)");
                                    int liters = Convert.ToInt32(Console.ReadLine());
                                    if (fuels[name_mark].Quantity > liters)
                                    {
                                        fuels[name_mark].Quantity -= liters;
                                        fuels[name_mark].Cashbox += (fuels[name_mark].Price * liters);
                                    }
                                    else Console.WriteLine($"Извините, на станции осталось лишь { fuels[name_mark].Quantity}л бензина ");
                                }
                                else Console.WriteLine("Такой марки нет, попробуйте еще раз!");
                            


                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите пароль для входа в систему: ");
                            string pass = Console.ReadLine();
                            Console.Clear();
                            if (pass == fuelStation.Password)
                            {
                                Console.WriteLine("1.Просмотр информации cо всех автозаправках\n" +
                                                  "2.Пополнить балланс топлива\n" +
                                                  "3.Сбор денежных средств со всех автозаправок\n" +
                                                  "4.Добавить топливо\n" +
                                                  "5.Удалить топливо\n");
                                string ch3_ = Console.ReadLine();
                                int ch3 = Convert.ToInt32(ch3_);
                                switch (ch3)
                                {
                                    case 1:
                                        {
                                            if (fuels.Count != 0)
                                                fuelStation.Show(fuels);
                                            else Console.WriteLine("На станции нет ни одного вида бензина!");
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Clear();
                                            fuelStation.ShowNameFuel(fuels);
                                            Console.Write("Какой запрвке желаете пополнить топливо: ");
                                            int liters = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("\nНа сколько (л) хотите пополнить ");
                                            int liters1 = Convert.ToInt32(Console.ReadLine());
                                            fuels[liters].Quantity += liters1;
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 3:
                                        {
                                            fuelStation.TakeMoney(fuels);
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.Write("Введите название топлива: ");
                                            string type = Console.ReadLine();
                                            Console.Write("Введите цену топлива: ");
                                            int price = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Введите количество топлива: ");
                                            int quantity = Convert.ToInt32(Console.ReadLine());

                                            Fuel f1 = new Fuel { Price = price, Type = type, Quantity = quantity };
                                            fuelStation.Add(fuels, f1);
                                            Console.ReadKey();
                                            break;
                                        }
                                    case 5:
                                        {
                                            fuelStation.ShowNameFuel(fuels);
                                            Console.Write("Введите номер: ");
                                            int quantity = Convert.ToInt32(Console.ReadLine());
                                            fuelStation.Remove(fuels, fuels[quantity]);
                                            Console.ReadKey();
                                            break;
                                        }
                                }

                            }
                            else
                            {
                                Console.WriteLine("Пароль введен неверно!");
                            }
                            Console.ReadKey();
                            break;
                        }
                }
            } while (ch != "3");
        }
    }
}
