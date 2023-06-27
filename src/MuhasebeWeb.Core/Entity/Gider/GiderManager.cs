using Abp.Domain.Services;
using MuhasebeWeb.Entity.Gelir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.Gider
{
	public class GiderManager:DomainService
	{
		private readonly IGelirRepository _gelirRepository;
		public GiderManager(IGelirRepository gelirRepository)
		{
			_gelirRepository = gelirRepository;
		}
	}
}
