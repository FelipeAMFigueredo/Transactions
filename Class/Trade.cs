using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transactions.Interfaces.ITrade

namespace Transactions
{
	class Trade : ITrade
	{
		protected double Value { get; private set; }
		protected string ClientSector { get; private set; }
		
		public class Trade(double value, string clientSector){
			this.Value = value;
			this.ClientSector = clientSector;
		}
	}
}
