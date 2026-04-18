using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Clientes.Clientes
{
    public class ClienteAppService : CrudAppService<
            Cliente, //The Cliente entity
            ClienteDto, //Used to show Clientes
            Guid, //Primary key of the Cliente entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateClienteDto>, //Used to create/update a Cliente
        IClienteAppService //Repository
    {
        public ClienteAppService(IRepository<Cliente, Guid> repository)
            : base(repository)
        {

        }
    }
}
