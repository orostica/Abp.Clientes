using Abp.Clientes.Clientes;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Abp.Clientes;

public class ClienteStoreDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Cliente, Guid> _clienteRepository;

    public ClienteStoreDataSeederContributor(IRepository<Cliente, Guid> clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _clienteRepository.GetCountAsync() <= 0)
        {
            await _clienteRepository.InsertAsync(
                new Cliente
                {
                    Codigo = "A123456",
                    Nome = "Andre",
                    DataNascimento = new DateOnly(1990, 1, 1)
                },
                autoSave: true
            );

            await _clienteRepository.InsertAsync(
                new Cliente
                {
                    Codigo = "B123456",
                    Nome = "Joao",
                    DataNascimento = new DateOnly(1995, 2, 1)
                },
                autoSave: true
            );
        }
    }
}
