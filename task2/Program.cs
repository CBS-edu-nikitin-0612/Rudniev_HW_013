using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(28, 32, 0.35);
            char valutaTo = 'U';
            Console.Write("Выберите валюту для конвертации('U'-usd, 'E'-eur, 'R'-rub, 'G'-grn): ");
            char valuta = Convert.ToChar(Console.ReadLine().ToUpper());
            if (valuta == 'G')
            {
                Console.Write("В какую валюту конвертировать ('U'-usd, 'E'-eur, 'R'-rub): ");
                valutaTo = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            Console.Write("Введите сумму для конвертации: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (valuta == 'U') 
                Console.WriteLine("Сумма в grn: " + converter.UsdToGrn(amount));
            if (valuta == 'E')
                Console.WriteLine("Сумма в grn: " + converter.EurToGrn(amount));
            if (valuta == 'R')
                Console.WriteLine("Сумма в grn: " + converter.RubToGrn(amount));
            if (valuta == 'G' & valutaTo == 'U')
                Console.WriteLine("Сумма в usd: " + converter.GrnToUsd(amount));
            if (valuta == 'G' & valutaTo == 'E')
                Console.WriteLine("Сумма в eur: " + converter.GrnToEur(amount));
            if (valuta == 'G' & valutaTo == 'R')
                Console.WriteLine("Сумма в rub: " + converter.GrnToRub(amount));
        }
    }
}
