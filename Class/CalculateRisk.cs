using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trade;
using System.Threading.Tasks;

namespace Transactions
{
	public class CalculateRisk
	{
		public string Calculate(Trade trade){			
			ICategory LR = new LowRisk();
			ICategory MR = new MediumRisk();
			ICategory HR = new HighRisk();
			ICategory NR = new NoRisk();
			
			LR.Next = MR;
			MR.Next = HR;
			HR.Next = NR;
			
			return LR.Calculate(trade);
		}
	}
}
