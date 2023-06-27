using Abp.Domain.Services;
using MuhasebeWeb.Entity.AlimTurleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.AlimTuru
{
	public class AlimTuruManager:DomainService
	{
		private readonly IAlimTuruRepository alimTuruRepository;

		public AlimTuruManager(IAlimTuruRepository alimTuruRepository)
		{
			this.alimTuruRepository = alimTuruRepository;
		}
	}
}
