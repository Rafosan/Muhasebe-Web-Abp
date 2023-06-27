using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.Gider
{
	public interface IGiderRepository:IRepository<GiderEntity, Guid>
	{
		Task<IEnumerable<GiderEntity>> GetAllForIhaleDto();
		IQueryable<GiderEntity> GetQueryForActiveIhale();
	}
}
