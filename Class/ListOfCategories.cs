using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions
{
	class ListOfCategories
	{
		public IList<Trade> trades { get; private set; }
		
		public void AddTrade(Trade trade){
			trades.Add(trade);
		}
	}
}
