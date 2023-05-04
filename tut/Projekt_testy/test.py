import requests
import urllib.parse

symbol = "GOOGL"
api_key = "63NG7JHXNRBY41XK"
url = f"https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol={urllib.parse.quote_plus(symbol)}&apikey={api_key}"
response = requests.get(url)
response.raise_for_status()
quote = response.json()

print(float(quote['Global Quote']['05. price']))


url2 = f'https://www.alphavantage.co/query?function=OVERVIEW&symbol={urllib.parse.quote_plus(symbol)}&apikey={api_key}'
r2 = requests.get(url2)
data2 = r2.json()
#company name
print(data2['Name'])