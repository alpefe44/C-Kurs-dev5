using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	interface IKampanyaService
	{
		void Add(Kampanya kampanya);
		void Delete(Kampanya kampanya);
		void Update(Kampanya kampanya,double DiscountRate);

		void HesaplaDiscount(Kampanya kampanya,Game game);
	}
}
