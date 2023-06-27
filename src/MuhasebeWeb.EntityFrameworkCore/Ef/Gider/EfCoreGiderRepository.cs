using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using MuhasebeWeb.Entity.AlimUsulu;
using MuhasebeWeb.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Ef.Gider
{
	public class EfCoreGiderRepository : EfCoreRepositoryBase<MuhasebeWebDbContext, AlimUsuluEntity, Guid>, IAlimUsuluRepository
	{
		public EfCoreGiderRepository(IDbContextProvider<MuhasebeWebDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}
