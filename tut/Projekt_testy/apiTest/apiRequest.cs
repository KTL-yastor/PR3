using System;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace apiTest
{
    internal class apiRequest
    {
        public async Task<StockQuote> LookupAsync(string symbol) //asynchroniczna funkcja zwracajaca typ StockQuote, nie blokuje glownego wątku
        {
            StockQuote quote = null;

            try
            {
                //string apiKey = Environment.GetEnvironmentVariable("API_KEY");
                // {Uri.EscapeDataString(symbol)} jest to zabezpieczenie przed błędami w przypadku gdyby symbol zawierał znaki specjalne
                string PriceUrl = $"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol={Uri.EscapeDataString(symbol)}&apikey=63NG7JHXNRBY41XK";
                string NameUrl = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={Uri.EscapeDataString(symbol)}&apikey=63NG7JHXNRBY41XK";
                using (HttpClient client = new HttpClient())
                {

                    // uzyskanie informacji o cenie
                    HttpResponseMessage responsePrice = await client.GetAsync(PriceUrl);
                    responsePrice.EnsureSuccessStatusCode(); // sprawdzenie czy odpowiedź jest poprawna
                    string contentPrice = await responsePrice.Content.ReadAsStringAsync();
                    JsonDocument jsonDocumentPrice = JsonDocument.Parse(contentPrice);
                    // uzyskanie pelnej nazwy firmy
                    HttpResponseMessage responseName = await client.GetAsync(NameUrl);
                    responseName.EnsureSuccessStatusCode(); // sprawdzenie czy odpowiedź jest poprawna
                    string contentName = await responseName.Content.ReadAsStringAsync();
                    JsonDocument jsonDocumentName = JsonDocument.Parse(contentName);
                    // utworzenie obiektu typu StockQuote i przypisanie do niego danych
                    quote = new StockQuote
                    {
                        Symbol = symbol,
                        Name = jsonDocumentName.RootElement.GetProperty("bestMatches").EnumerateArray().First().GetProperty("2. name").GetString(),
                        Price = jsonDocumentPrice.RootElement.GetProperty("Global Quote").GetProperty("05. price").GetString()
                    };

                } // koniec bloku using (HttpClient client = new HttpClient()) - zamyka połączenie z serwerem i zwalnia zasoby 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas pobierania danych: " + ex.Message);
                return null;
            }

            return quote;
        }
    }
}
