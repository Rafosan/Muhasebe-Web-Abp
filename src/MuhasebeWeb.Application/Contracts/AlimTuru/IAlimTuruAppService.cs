using Abp.Application.Services;
using MuhasebeWeb.Entity.AlimTurleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Application.Contracts.AlimTuru
{
    public interface IAlimTuruAppService : IApplicationService
    {
        //stay on the here
        Task<AlimTuruDTO> GetAsync(Guid id);

        Task<IEnumerable<AlimTuruDTO>> GetAllAsync();
		Task<AlimTuruEntity> GetEntityAsync(Guid id);

		//Task<IEnumerable<AlimTuruDTO>> GetByFilter(Expression<Func<AlimTuruEntity, bool>> filter);

		Task<AlimTuruDTO> CreateAsync(CreateAlimTuruDTO input);

        Task UpdateAsync(Guid id, UpdateAlimTuruDTO input);

        Task DeleteAsync(Guid id);
    }
}
