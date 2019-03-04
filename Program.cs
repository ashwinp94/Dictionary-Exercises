using System;
using System.Collections.Generic;

namespace Stock_purchase
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("NFLX", "Netflix");
            stocks.Add("AAPL", "Apple");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "AAPL", 406.34 } });
            purchases.Add(new Dictionary<string, double>() { { "NFLX", 406.34 } });
                        purchases.Add(new Dictionary<string, double>() { { "GM", 300.21 } });


            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            foreach (Dictionary<string, double> purchase in purchases)
            {
                {
                    foreach (KeyValuePair<string, double> stock in purchase)
                    {
                        string key = $"{stock.Key}";
                        string fullName = stocks[stock.Key];

                        if(stockReport.ContainsKey(fullName)) {

						stockReport[fullName] += stock.Value;

                        }else{
                            stockReport.Add($"{fullName}", stock.Value);

                        }

                    }
                }

            }
                foreach (KeyValuePair<string, double> stock in stockReport)
			{
				    Console.WriteLine($"The stock in {stock.Key} is worth {stock.Value}");
			}
        }
    }
}