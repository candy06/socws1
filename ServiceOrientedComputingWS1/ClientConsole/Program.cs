using ClientConsole.VelibService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientConsole
{
    class Program
    {

        private static ServiceClient client = new ServiceClient();
        private static bool isReady = true;
        private static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            while(isReady)
            {
                Console.Write("Saisissez une commande (help pour l'aide, q pour quitter): ");
                string input = Console.ReadLine();
                Console.WriteLine(Compute(input));
            }
        }

        static void Clear(StringBuilder sb)
        {
            sb.Length = 0;
            sb.Capacity = 0;
        }

        static string Compute(string cmd)
        {

            sb.Clear();
            string cityName = "";
            string stationName = "";

            switch (cmd)
            {
                case "help":
                    sb.Append("Liste des commandes:\n" +
                        "- GetCities : affiche la liste des villes qui utilisent Velib.\n" +
                        "- GetStations : affiche la liste des stations pour une ville.\n" +
                        "- GetAvailableBikes <cityName> <stationName> : affiche le nombre de velos disponibles pour la station donnee.\n");
                    return sb.ToString();
                case "q":
                    isReady = false;
                    return "Good Bye!";
                case "GetCities":
                    City[] cities = client.GetCities();
                    int numberOfCities = cities.Length;
                    for (int i = 0; i < numberOfCities; i++)
                    {
                        sb.Append("Ville no." + (i+1) + ": " + cities[i].Name + "\n");
                    }
                    return sb.ToString();
                case "GetStations":
                    Console.Write("Nom de la ville: ");
                    cityName = Console.ReadLine();
                    Station[] stations = client.GetStationsOf(cityName);
                    int numberOfStation = stations.Length;
                    for (int i = 0; i < numberOfStation; i++)
                    {
                        sb.Append("Station no." + (i + 1) + ": " + stations[i].Name + "\n");
                    }
                    return sb.ToString();
                case "GetAvailableBikes":
                    Console.Write("Nom de la ville: ");
                    cityName = Console.ReadLine();
                    Console.Write("Nom de la station: ");
                    stationName = Console.ReadLine();
                    int availableBikes = client.GetAvailableBikesForStation(stationName, cityName);
                    sb.Append("Velo(s) disponible(s): " + availableBikes + "\n");
                    return sb.ToString();
                default:
                    return "";
            }
        }

    }
}
