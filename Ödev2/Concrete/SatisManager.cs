using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	internal class SatisManager : ISatisService
	{

		IUserValidationService _userValidationService;

		public SatisManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;	
		}

		public void Sell(Gamer gamer, Game game)
		{
			if (_userValidationService.Validation(gamer) && _userValidationService.Validation(game))
				Console.WriteLine("Oyun satışı gerçekleşti");
		}
	}
}
