using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Entity.AlimTurleri
{
	public class AlimTuruEntity: FullAuditedAggregateRoot<Guid>
	{
		public string AlimTuru { get; set; }
	}
}
