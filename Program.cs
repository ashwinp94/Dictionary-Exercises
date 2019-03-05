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
                        string fullName = stocks[stock.Key];

                        if (stockReport.ContainsKey(fullName))
                        {

                            stockReport[fullName] += stock.Value;

                        }
                        else
                        {
                            stockReport.Add($"{fullName}", stock.Value);

                        }

                    }
                }
            }

            foreach (KeyValuePair<string, double> stock in stockReport)
            {
                Console.WriteLine($"The stock in {stock.Key} is worth {stock.Value}");
            }

            //Iterating over planets

            List<string> planetList = new List<string>()
            { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add(new Dictionary<string, string>() { { "Mariner 10", "Mercury" } });
            probes.Add(new Dictionary<string, string>() { { "Messenger", "Mercury" } });
            probes.Add(new Dictionary<string, string>() { { "Mariner 2", "Venus" } });
            probes.Add(new Dictionary<string, string>() { { "Venera 4", "Venus" } });
            probes.Add(new Dictionary<string, string>() { { "Venus Express", "Venus" } });
            probes.Add(new Dictionary<string, string>() { { "We live here", "Earth" } });
            probes.Add(new Dictionary<string, string>() { { "Mariner 9", "Mars" } });
            probes.Add(new Dictionary<string, string>() { { "Opportunity", "Mars" } });
            probes.Add(new Dictionary<string, string>() { { "Curiosity", "Mars" } });
            probes.Add(new Dictionary<string, string>() { { "Pioneer 11", "Jupiter" } });
            probes.Add(new Dictionary<string, string>() { { "Pioneer 12", "Jupiter" } });
            probes.Add(new Dictionary<string, string>() { { "Voyager 1", "Saturn" } });
            probes.Add(new Dictionary<string, string>() { { "Cassini", "Saturn" } });
            probes.Add(new Dictionary<string, string>() { { "Voyager Two", "Uranus" } });
            probes.Add(new Dictionary<string, string>() { { "Voyager 2", "Neptune" } });

            foreach (string planets in planetList) // iterate planets
            {
                List<string> matchingProbes = new List<string>();

                foreach (Dictionary<string, string> probe in probes) // iterate probes
                {
                    foreach (KeyValuePair<string, string> spaceCraft in probe)
                    {

                        string planet = spaceCraft.Value;
                        string probeName = spaceCraft.Key;

                        if ((! matchingProbes.Contains(probeName)) && planets == planet)
                        {
                            matchingProbes.Add(probeName);
                        }

                    }
                }

                string probeList = String.Join(", ", matchingProbes);
                Console.WriteLine($"{planets}: {probeList}");

            }
        }
    }
}