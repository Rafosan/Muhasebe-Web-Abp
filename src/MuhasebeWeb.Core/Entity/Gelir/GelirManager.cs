using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.Gelir
{
	public class GelirManager: DomainService
	{
		private readonly IGelirRepository _gelirRepository;
		public GelirManager(IGelirRepository gelirRepository)
		{
			_gelirRepository = gelirRepository;
		}
	}
}
