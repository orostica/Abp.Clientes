using System;
using Volo.Abp.Application.Dtos;

namespace Abp.Clientes.Clientes;

public class ClienteDto : AuditedEntityDto<Guid>
{
    public string Codigo { get; set; }

    public string Nome { get; set; }

    public DateOnly DataNascimento { get; set; }
}