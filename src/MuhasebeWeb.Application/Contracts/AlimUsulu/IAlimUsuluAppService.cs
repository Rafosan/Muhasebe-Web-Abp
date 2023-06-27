using Abp.Application.Services;
using MuhasebeWeb.Application.Contracts.AlimUsulu;
using MuhasebeWeb.Entity.AlimUsulu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.AlimUsulu
{
	public interface IAlimUsuluAppService:IApplicationService
	{
		Task<AlimUsuluDTO> GetAsync(Guid id);

		Task<IEnumerable<AlimUsuluDTO>> GetAllAsync();
		Task<AlimUsuluEntity> GetEntityAsync(Guid id);

		//Task<IEnumerable<AlimUsuluDTO>> GetByFilter(Expression<Func<AlimUsuluEntity, bool>> filter);

		Task<AlimUsuluDTO> CreateAsync(CreateAlimUsuluDTO input);

		Task UpdateAsync(Guid id, UpdateAlimUsuluDTO input);

		Task DeleteAsync(Guid id);
	}
}
