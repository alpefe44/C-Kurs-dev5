using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	internal class Gamer:IEntity
	{
		public int TcNo { get; set; }	
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public int DogumYili { get; set; }
	}
}
