using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	internal class Game:IEntity
	{
		public string Name { get; set; }
		public double Fiyat { get; set; }
		public bool SatisDurum { get; set; }
	}
}
