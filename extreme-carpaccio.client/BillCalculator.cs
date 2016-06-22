using System;
using xCarpaccio;

namespace xCarpaccio.client
{
    public class BillCalculator
    {
        public static Bill CalculerPrice(Order order)
        {
            // Variable 

            Bill billFacture = new Bill();
            decimal sumArticle = 0;
            decimal totalSum = 0;
            decimal totalSumTX = 0;

            // parcour d'une facture
            for (int i = 0; i < order.Prices.Length; i++)
            {
                
                sumArticle = order.Prices[i] * order.Quantities[i];
                totalSum += sumArticle;

                switch (order.Country)
                {
                   
                    case "DE":
                    totalSumTX = Math.Round(totalSum * (1.2m), 2);
                    break;
                    case "FR":
                    totalSumTX = Math.Round(totalSum * (1.2m), 2);
                    break;
                    case "RO":
                    totalSumTX = Math.Round(totalSum * (1.2m), 2);
                    break;
                    case "NL":
                    totalSumTX = Math.Round(totalSum * (1.2m), 2);
                    break;
                    case "EL":
                    totalSumTX = Math.Round(totalSum * (1.2m), 2);
                    break;
                    case "LV":
                    totalSumTX = Math.Round(totalSum * (1.2m), 2);
                    break;
                    case "UK":
                    totalSumTX = Math.Round(totalSum * (1.21m), 2);
                    break;
                    case "PL":
                    totalSumTX = Math.Round(totalSum * (1.21m), 2);
                    break;
                    case "BG":
                    totalSumTX = Math.Round(totalSum * (1.21m), 2);
                    break;
                    case "IE":
                    totalSumTX = Math.Round(totalSum * (1.21m), 2);
                    break;
                    case "CI":
                    totalSumTX = Math.Round(totalSum * (1.21m), 2);
                    break;
                    case "DK":
                    totalSumTX = Math.Round(totalSum * (1.21m), 2);
                    break;
                    case "IT":
                    totalSumTX = Math.Round(totalSum * (1.25m), 2);
                    break;
                    case "LU":
                    totalSumTX = Math.Round(totalSum * (1.25m), 2);
                    break;
                    case "ES":
                    totalSumTX = Math.Round(totalSum * (1.19m), 2);
                    break;
                    case "PT":
                    totalSumTX = Math.Round(totalSum * (1.23m), 2);
                    break;
                    case "SE":
                    totalSumTX = Math.Round(totalSum * (1.23m), 2);
                    break;
                    case "HR":
                    totalSumTX = Math.Round(totalSum * (1.23m), 2);
                    break;
                    case "LT":
                    totalSumTX = Math.Round(totalSum * (1.23m), 2);
                    break;
                }

            }

            // Ajout de la Reduction 

            if (order.Reduction != "PAY THE PRICE")
            {
                if (totalSumTX >= 1000)
                {

                    totalSumTX = totalSumTX - (totalSumTX*(0.03m));
                }
                if (totalSumTX >= 5000)
                {
                    totalSumTX = totalSumTX - (totalSumTX*(0.05m));
                }
                if (totalSumTX >= 7000)
                {
                    totalSumTX = totalSumTX - (totalSumTX*(0.07m));
                }
                if (totalSumTX >= 10000)
                {
                    totalSumTX = totalSumTX - (totalSumTX*(0.10m));
                }
                if (totalSumTX >= 50000)
                {
                    totalSumTX = totalSumTX - (totalSumTX*(0.15m));
                }

            }
            billFacture.total = totalSumTX;
            return billFacture;
        }
    }
}