using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Interfaces.ICategory;

namespace Transactions
{
	public class LowRisk : ICategory
	{
		protected ICategory Next { get; set; }
		
		public string Calculate(Trade trade){
			if(trade.Value < 1000.000 && 'Public'.Equals(trade.ClientSector)){
				return "LOWRISK"
			}
			return Next.Calculate(trade);
		}
	}
}
