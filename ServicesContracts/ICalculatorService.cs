using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicesContracts
{
	[ServiceContract]
	public interface ICalculatorService
	{
		[OperationContract]
		int Sum(int number1, int number2);
	}
}
