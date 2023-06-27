using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.Gelir
{
	public class GelirEntity:FullAuditedAggregateRoot<Guid>
	{
		public string Gelir { get; set; }
	}
}
