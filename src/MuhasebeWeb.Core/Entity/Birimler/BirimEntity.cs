using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.Birim
{
    public class BirimEntity: FullAuditedAggregateRoot<Guid>
    {
        public string BirimAdi { get; set; }
    }
}
