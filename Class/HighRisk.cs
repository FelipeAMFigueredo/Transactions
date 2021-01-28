using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Interfaces.ICategory;

namespace Transactions
{
	public class HighRisk : ICategory
	{
		protected ICategory Next { get; set; }
		
		public string Calculate(Trade trade){
			if(trade.Value > 1000.000 && 'Private'.Equals(trade.ClientSector)){
				return "HIGHRISK"
			}
			return Next.Calculate(trade);
		}
	}
}
