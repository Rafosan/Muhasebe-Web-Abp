using Abp.Application.Services;
using MuhasebeWeb.Application.Contracts.AlimTuru;
using MuhasebeWeb.Entity.AlimTurleri;
using MuhasebeWeb.Entity.Gider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Contracts.Gider
{
	public interface IGiderAppService:IApplicationService
	{
		Task<GiderDTO> GetAsync(Guid id);
		Task<IEnumerable<GiderDTO>> GetAllAsync();
		Task<GiderEntity> GetEntityAsync(Guid id);
		Task<GiderDTO> CreateAsync(CreateGiderDTO input);
		Task UpdateAsync(Guid id, UpdateGiderDTO input);
		Task DeleteAsync(Guid id);
	}
}
