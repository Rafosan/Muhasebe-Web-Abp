using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using MuhasebeWeb.Entity.AlimUsulu;
using MuhasebeWeb.EntityFrameworkCore;
using System;

namespace MuhasebeWeb.AlimTuru
{
	public class EfCoreAlimUsuluRepository:EfCoreRepositoryBase<MuhasebeWebDbContext, AlimUsuluEntity,Guid>,IAlimUsuluRepository
	{
		public EfCoreAlimUsuluRepository(IDbContextProvider<MuhasebeWebDbContext> dbContextProvider):base(dbContextProvider)
		{

		}
	}
}
