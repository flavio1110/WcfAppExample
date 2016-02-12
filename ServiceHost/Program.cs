using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServicesImpl;

namespace ServiceAppHost
{
	class Program
	{
		static void Main()
		{
			using (var host = new ServiceHost(typeof(CalculatorService)))
			{
				host.Open();
				Console.WriteLine("Host Started @ " + DateTime.Now.ToString());
				Console.ReadLine();
			}
		}
	}
}
