using xCarpaccio.client;
using NUnit.Framework;

namespace extreme_carpaccio.test
{
    public class CarpaccioTest
    {
        

        [Test]
        public void calculTotalBill()
        {
            // Création d'une commande
            Order order = new Order();
            order.Prices = new[] { 10.66m, 10m, 10m, 10.5m, 10m };
            order.Quantities = new[] { 1, 2, 3, 4, 5 };
            order.Country = "DE";
            order.Reduction = "PAY THE PRICE";
            
            //Calcul du prix 
            Bill bill = BillCalculator.CalculerPrice(order);

            //test
            Assert.AreEqual(183.19m, bill.total);
         
        }
    }
}
