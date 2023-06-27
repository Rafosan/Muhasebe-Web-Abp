using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using MuhasebeWeb.Entity.AlimTurleri;
using MuhasebeWeb.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.AlimTuru
{
	internal class EFCoreAlimTuruRepository : EfCoreRepositoryBase<MuhasebeWebDbContext, AlimTuruEntity, Guid>, IAlimTuruRepository
	{
		public EFCoreAlimTuruRepository(IDbContextProvider<MuhasebeWebDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}
