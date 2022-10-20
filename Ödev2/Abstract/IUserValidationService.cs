using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
	internal interface IUserValidationService
	{
		bool Validation(Gamer gamer);

		bool Validation(Game game);	
	}
}
