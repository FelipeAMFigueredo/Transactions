using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions
{
	public interface ICategory
	{
		string Calculate(Trade trade);
		ICategory Next { get; set; }
	}
}