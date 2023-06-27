using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using MuhasebeWeb.Entity.Birim;
using MuhasebeWeb.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.AlimTuru
{
    public class EfCoreBirimRepository : EfCoreRepositoryBase<MuhasebeWebDbContext, BirimEntity, Guid>, IBirimRepository
    {
        public EfCoreBirimRepository(IDbContextProvider<MuhasebeWebDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
