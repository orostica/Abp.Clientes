using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Abp.Clientes.Clientes
{
    public class Cliente : AuditedAggregateRoot<Guid>
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public DateOnly DataNascimento { get; set; }
    }
}
