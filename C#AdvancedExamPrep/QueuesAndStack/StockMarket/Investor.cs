using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {

        public Investor(string name, string email, decimal money, string broker)
        {
            FullName = name;
            EmailAdrress = email;
            MoneyToInvest = money;
            BrokerName = broker;

            Portfolio = new List<Stock>();
        }
        public List<Stock> Portfolio { get; set; }

        public string FullName { get; set; }
        public string EmailAdrress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public int Count {get { return Portfolio.Count;} }

        public void BuyStock(Stock stock)
        {
            if (stock.MarkerCapitalization >= 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                Portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }

        public string SellStock(string companyName, decimal sellingPrice)
        {
            if (Portfolio.Any(c => c.CompanyName == companyName))
            {
                int index = Portfolio.FindIndex(c => c.CompanyName == companyName);
                if (sellingPrice <= Portfolio[index].PricePerShare)
                {
                    return $"Cannot sell {companyName}.";
                }
                else
                {
                    int indexHere = Portfolio.FindIndex(c => c.CompanyName == companyName);
                    Portfolio.RemoveAt(indexHere);
                    MoneyToInvest += sellingPrice;
                    return $"{companyName} was sold.";
                }

            }
            else
            {
                return $"{companyName} does not exist.";
            }
        }

        public Stock FindStock(string companyName)
        {
            for (int i = 0; i < Portfolio.Count; i++)
            {
                if (Portfolio[i].CompanyName == companyName)
                {
                    return Portfolio[i];
                }
            }
            return null; 
        }

        public Stock FindBiggestCompany()
        {
            if (Portfolio.Count == 0)
            {
                return null;
            }
            else
            {
                var stockWinner = Portfolio[0];
                for (int i = 1; i < Portfolio.Count; i++)
                {
                    if (Portfolio[i].MarkerCapitalization > stockWinner.MarkerCapitalization)
                    {
                        stockWinner = Portfolio[i];
                    }
                }
                return stockWinner;
            }
        }

        public string InvestorInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in Portfolio)
            {
                sb.AppendLine(stock.ToString());
            }
            return sb.ToString();        
        }
    }
}
