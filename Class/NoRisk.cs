using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Interfaces.ICategory;

namespace Transactions
{
	public class NoRisk : ICategory
	{
		protected ICategory Next { get; set; }
		
		public string Calculate(Trade trade){
			return "";
		}
	}
}