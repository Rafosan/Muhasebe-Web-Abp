using Abp.Domain.Services;
using MuhasebeWeb.Entity.AlimUsulu;

namespace MuhasebeWeb.Entity.AlimUsulu
{
	public class AlimUsuluManager: DomainService
	{
		private readonly IAlimUsuluRepository alimUsuluRepository;

		public AlimUsuluManager(IAlimUsuluRepository alimUsuluRepository)
		{
			this.alimUsuluRepository = alimUsuluRepository;
		}
	}
}
