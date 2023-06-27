using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using MuhasebeWeb.Entity.AlimUsulu;
using MuhasebeWeb.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Ef.Gelir
{
	public class EfCoreGelirRepository : EfCoreRepositoryBase<MuhasebeWebDbContext, AlimUsuluEntity, Guid>, IAlimUsuluRepository
	{
		public EfCoreGelirRepository(IDbContextProvider<MuhasebeWebDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}
