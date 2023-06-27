using Abp.Application.Services;
using MuhasebeWeb.Application.Contracts.AlimTuru;
using MuhasebeWeb.Entity.AlimTurleri;
using MuhasebeWeb.Entity.Gelir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Contracts.Gelir
{
	public interface IGelirAppService:IApplicationService
	{
		Task<GelirDTO> GetAsync(Guid id);
		Task<IEnumerable<GelirDTO>> GetAllAsync();
		Task<GelirEntity> GetEntityAsync(Guid id);
		Task<GelirDTO> CreateAsync(CreateGelirDTO input);
		Task UpdateAsync(Guid id, UpdateGelirDTO input);
		Task DeleteAsync(Guid id);
	}
}
