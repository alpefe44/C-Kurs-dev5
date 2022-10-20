using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	internal class UserValidationManager : IUserValidationService
	{
		public bool Validation(Gamer gamer)
		{
			if((gamer.Ad == "Alp" && gamer.Soyad == "Akpınar" && gamer.TcNo == 12345 && gamer.DogumYili == 2001)

				)
			{
				return true;
			}

			else
			{
				return false;
			}
		}
		public bool Validation(Game game)
		{
			if(game.SatisDurum == true)
			{
				return true;
			}

			else
			{
				return false;
			}
		}

	}
}
