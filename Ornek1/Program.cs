using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
	internal class Program
	{
		static void Main(string[] args)
		{

		}
	}

	
	class Product : IEntity
	{
		public int id { get; set; }
		public string name { get; set; }
		public decimal Price { get; set; }
	}

	class ProductManager : IProductService
	{


		
		public void Sell(Product product, ICustomer customer)
		{
			decimal price = product.Price;
			price = customer.GetPrice(price);

		}
	}

	class FakeBankService : IBankService
	{
		public decimal ConvertRate(CurrencyRate currencyRate)
		{
			return currencyRate.Price / (decimal)5.30;
		}
	}

	interface IBankService
	{
		decimal ConvertRate(CurrencyRate currencyRate);

	}

	class CurrencyRate
	{
		public decimal Price { get; set; }
		public int Currency { get; set; }
	}
	interface IProductService
	{
		void Sell(Product product,ICustomer customer);
	}

	class Officer : ICustomer
	{
		public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public decimal GetPrice(decimal price)
		{
			return price;
		}
	}

	class Ogrenci : ICustomer
	{
		public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public decimal GetPrice(decimal price)
		{
			return price* (decimal)0.9;
		}
	}

	interface ICustomer
	{
		int Id { get; set; }
		string Name { get; set; }
		decimal GetPrice(decimal price);

	}

	interface IEntity
	{

	}
}
