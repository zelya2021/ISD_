using System;
using System.Collections.Generic;

namespace RefuelingSt
{
    class FuelStation
    {
        public List<Fuel> Fuels { get; set; }
        public decimal AllMoney=0;
        public void ShowNameFuel(List<Fuel> fuels)
        {
            Console.WriteLine("Имеющиеся топлива: ");
            for (int i = 0; i < fuels.Count; i++)
            {
                Console.WriteLine($"{i} - {fuels[i].Type}");
            }
            Console.WriteLine();
        }
        public void PriceList(List<Fuel> fuels)
        {
            Console.WriteLine("*******Прайс-лист*******");
            for (int i=0;i< fuels.Count;i++)
            {
                Console.WriteLine($"Цена {fuels[i].Type} - {fuels[i].Price} грн");
            }
            Console.WriteLine();
        }
        public void Show(List<Fuel> fuels)
        {
            for (int i = 0; i < fuels.Count; i++)
            {
                Console.WriteLine($"***Инфориация о {fuels[i].Type} топливе***");
                Console.WriteLine($"Количесво - {fuels[i].Quantity}(л)\n" +
                                  $"На счету -  {fuels[i].Cashbox} (грн)/n");
            }
        }
        public void Add(List<Fuel> fuels,Fuel fuel)
        {
            fuels.Add(fuel);
        }
        public void Remove(List<Fuel> fuels, Fuel fuel)
        {
            fuels.Remove(fuel);
        }
        public void TakeMoney(List<Fuel> fuels)
        {
            for (int i = 0; i < fuels.Count; i++)
            {
                AllMoney += fuels[i].Cashbox;
            }
            for (int i = 0; i < fuels.Count; i++)
            {
               fuels[i].Cashbox=0;
            }
            Console.WriteLine($"На счету у станции {AllMoney}(грн)");
        }
        public string Password { get; set; }
    }
}
