using MuhasebeWeb.Application.Contracts.AlimTuru;
using MuhasebeWeb.Contracts.Gelir;
using MuhasebeWeb.Contracts.Gider;
using MuhasebeWeb.Entity.AlimTurleri;
using MuhasebeWeb.Entity.Gelir;
using MuhasebeWeb.Entity.Gider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.EntityApp.Gelir
{
	public class GelirAppService : MuhasebeWebAppServiceBase, IGelirAppService
	{
		private readonly IGelirRepository _gelirRepository;
		public GelirAppService(IGelirRepository gelirRepository)
		{
			_gelirRepository = gelirRepository;
		}

		public async Task<GelirDTO> CreateAsync(CreateGelirDTO input)
		{
			input.Gelir = input.Gelir.ToLower();
			var gelir = ObjectMapper.Map<GelirEntity>(input);
			var gelirDto = await _gelirRepository.InsertAsync(gelir);
			return ObjectMapper.Map<GelirDTO>(gelirDto);
		}

		public async Task DeleteAsync(Guid id)
		{
			await _gelirRepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<GelirDTO>> GetAllAsync()
		{
			var gelir = await _gelirRepository.GetAllListAsync();
			var gelirDto = ObjectMapper.Map<IEnumerable<GelirDTO>>(gelir);
			return gelirDto;
		}

		public async Task<GelirDTO> GetAsync(Guid id)
		{
			var gelir = await _gelirRepository.GetAsync(id);
			return ObjectMapper.Map<GelirDTO>(gelir);
		}

		public async Task<GelirEntity> GetEntityAsync(Guid id)
		{
			var gelir = await _gelirRepository.GetAsync(id);
			return gelir;
		}

		public async Task UpdateAsync(Guid id, UpdateGelirDTO input)
		{
			var gelirler = await _gelirRepository.GetAsync(id);
			gelirler.Gelir = input.Gelir.ToLower();
			await _gelirRepository.UpdateAsync(gelirler);
		}
	}
}
