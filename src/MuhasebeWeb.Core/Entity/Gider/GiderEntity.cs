using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.Gider
{
	public class GiderEntity : FullAuditedAggregateRoot<Guid>
	{
		public string Gider { get; set; }
	}
}
