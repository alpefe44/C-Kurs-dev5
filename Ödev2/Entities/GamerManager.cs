using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	internal class GamerManager : IGamerService
	{
		IUserValidationService _userValidationService;

		public GamerManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;
		}

		public void Add(Gamer gamer)
		{
			if (_userValidationService.Validation(gamer))
			{
				Console.WriteLine("Kayıt Oldu");
			}
			else
			{
				Console.WriteLine("Doğrulama Başarısız Oldu");
			}			
		}

		public void Remove(Gamer gamer)
		{
			Console.WriteLine("Kayıt Silindi");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine("Kayıt Güncellendi");
		}
	}
}
