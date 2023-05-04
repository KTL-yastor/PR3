using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Przykladowe symbole:Apple Inc. (AAPL)\r\nAlphabet Inc. (GOOGL)\r\nMicrosoft Corporation (MSFT)\r\nAmazon.com, Inc. (AMZN)\r\nMeta (formerly Facebook) Inc. (META)\r\nTesla Motors (TSLA)\r\nThe Goldman Sachs Group, Inc. (GS)\r\nThe Dow Jones Industrial Average (DJIA)\r\nThe S&P 500 Index (SPX)\r\nThe NASDAQ Composite Index (COMP)");
            //zapytaj o symbol
            //while nie wpisze exit to zapytaj ponownie
            while (true)
            {
                Console.WriteLine("Podaj symbol akcji: ");
                //wypisanie przykladowych 
                string symbol = Console.ReadLine();
                if (symbol == "exit")
                {
                    break;
                }
                //animacja ładowania danych (co 0.25 sek pojawia sie kolejna kropka w napisa Ładuje...)
                Console.Write("Trwa wyszukiwanie");
                for (int i = 0; i < 3; i++)
                {
                    System.Threading.Thread.Sleep(250);
                    Console.Write(".");
                }
                //nowa linia
                Console.WriteLine();
                //wynik
                Console.WriteLine("---------------Wynik-------------");


                apiRequest api = new apiRequest();
                StockQuote quote = api.LookupAsync(symbol).Result;
                if (quote != null)
                {
                    Console.WriteLine($"Nazwa: {quote.Name}");
                    Console.WriteLine($"Symbol: {quote.Symbol}");
                    //cena w formacie 0.00$
                    Console.WriteLine($"Cena: {quote.Price:C2}$");
                }
                else
                {
                    Console.WriteLine("Nie znaleziono akcji o podanym symbolu");
                }
                Console.WriteLine();

            }   
        }
    }
}
