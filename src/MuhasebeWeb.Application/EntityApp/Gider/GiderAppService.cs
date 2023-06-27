using MuhasebeWeb.Contracts.Gider;
using MuhasebeWeb.Entity.Gider;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuhasebeWeb.EntityApp.Gider
{
    public class GiderAppService : MuhasebeWebAppServiceBase, IGiderAppService
    {
        private readonly IGiderRepository _giderRepository;
        public GiderAppService(IGiderRepository giderRepository)
        {
            _giderRepository = giderRepository;
        }
        public async Task<GiderDTO> CreateAsync(CreateGiderDTO input)
        {
            input.Gider = input.Gider.ToLower();
            var gider = ObjectMapper.Map<GiderEntity>(input);
            var giderDto = await _giderRepository.InsertAsync(gider);
            return ObjectMapper.Map<GiderDTO>(giderDto);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _giderRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<GiderDTO>> GetAllAsync()
        {
            var gider = await _giderRepository.GetAllListAsync();
            var giderDto = ObjectMapper.Map<IEnumerable<GiderDTO>>(gider);
            return giderDto;
        }

        public async Task<GiderDTO> GetAsync(Guid id)
        {
            var gider = await _giderRepository.GetAsync(id);
            return ObjectMapper.Map<GiderDTO>(gider);
        }

        public async Task<GiderEntity> GetEntityAsync(Guid id)
        {
            var gider = await _giderRepository.GetAsync(id);
            return gider;
        }

        public async Task UpdateAsync(Guid id, UpdateGiderDTO input)
        {
            var giderler = await _giderRepository.GetAsync(id);
            giderler.Gider = input.Gider.ToLower();
            await _giderRepository.UpdateAsync(giderler);
        }
    }
}
