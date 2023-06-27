using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.Gelir
{
	public interface IGelirRepository:IRepository<GelirEntity,Guid>
	{
		Task<IEnumerable<GelirEntity>> GetAllForIhaleDto();
		IQueryable<GelirEntity> GetQueryForActiveIhale();
	}
}
