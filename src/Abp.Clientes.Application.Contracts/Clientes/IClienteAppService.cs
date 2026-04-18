using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Abp.Clientes.Clientes
{
    public interface IClienteAppService : ICrudAppService<
        ClienteDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateClienteDto>
    {
    }
}
