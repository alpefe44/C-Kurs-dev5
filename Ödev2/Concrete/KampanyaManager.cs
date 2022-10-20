using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	internal class KampanyaManager : IKampanyaService
	{
		public void Add(Kampanya kampanya)
		{
			Console.WriteLine("Yeni kampanya" + kampanya.Name + " kampanya şu kadar indirimle eklendi" + kampanya.DiscountRate);
		}

		public void Delete(Kampanya kampanya)
		{
			Console.WriteLine("Kampanya Silindi" + kampanya.Name);
		}

		public void HesaplaDiscount(Kampanya kampanya, Game game)
		{
			double DiscountAmount = (game.Fiyat * kampanya.DiscountRate) / 100;
			double DiscountPrice = game.Fiyat - DiscountAmount;
			game.Fiyat = DiscountPrice;
			Console.WriteLine("İndirimli ürün fiyati " + game.Name + " " + game.Fiyat);
		}

		public void Update(Kampanya kampanya, double DiscountRate)
		{
			kampanya.DiscountRate = DiscountRate;
			Console.WriteLine("Kampanya " + kampanya.Name + "yeni indirimle güncellendi " + kampanya.DiscountRate);	
		}
	}
}
