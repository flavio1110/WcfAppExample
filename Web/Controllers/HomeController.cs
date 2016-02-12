using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using Web.CalculatorService;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Proxy() // using service reference auto generated proxy
		{
			int sum = 0;
			using(var client = new CalculatorServiceClient("BasicHttpBinding_ICalculatorService"))
			{
				sum = client.Sum(1, 5);
			}
			return Content(sum.ToString());
		}


		public ActionResult ChannelFactory() // creating manual channel factory
		{
			var channelFactory = new ChannelFactory<ICalculatorService>("NetTcpBinding_ICalculatorService");

			ICalculatorService service = channelFactory.CreateChannel();

			int sum = service.Sum(100, 200);

			channelFactory.Close();


			return Content(sum.ToString());
		}

		public ActionResult IIS() // creating manual channel factory
		{
			var channelFactory = new ChannelFactory<ICalculatorService>("IISBasicHttpBinding_ICalculatorService");

			ICalculatorService service = channelFactory.CreateChannel();

			int sum = service.Sum(100, 200);

			channelFactory.Close();


			return Content(sum.ToString());
		}
	}
}
