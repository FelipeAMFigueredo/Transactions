using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Class.CalculateRisk;
using Transactions.Class.Trade;
using Transactions.Class.ListOfCategories;

namespace Transactions
{
	class Program
	{
		static void Main(String[] args){
			CalculateRisk calculateRisk = new calculateRisk();
			ListOfCategories categoriesList = new ListOfCategories();
			Trade trade = new Trade();
		
			while(categoriesList.Value != 0 && !"null".Equals(categoriesList.ClientSector)){
			
				Console.WriteLine("Insert the Value of the transaction. Digit 0 to finish");
				trade.Value = Convert.ToDouble(Console.ReadLine());
				
				Console.WriteLine("Insert the Client Sector of the transaction. Digit null to finish");
				trade.ClientSector = Console.ReadLine();
				
				categoriesList.AddTrade(New Trade(trade.Value, trade.ClientSector));
				Console.WriteLine("tradeCategories:"+calculateRisk.Calculate(categoriesList));
			}
					
			Console.ReadKey();
		}
	}
}