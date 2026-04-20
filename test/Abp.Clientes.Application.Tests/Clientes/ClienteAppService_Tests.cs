using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Xunit;
namespace Abp.Clientes.Clientes
{
    public abstract class ClienteAppService_Tests<TStatuModule> : ClientesApplicationTestBase<TStatuModule>
        where TStatuModule : IAbpModule
    {
        private readonly IClienteAppService _clienteAppService;

        protected ClienteAppService_Tests()
        {
            _clienteAppService = GetRequiredService<IClienteAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Clients()
        {
            //Act
            var result = await _clienteAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
         );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Nome == "Andre");
        }

        [Fact]
        public async Task Should_Create_A_Valid_Cliente()
        {
            //Act
            var result = await _clienteAppService.CreateAsync(
                new CreateUpdateClienteDto
                {
                    Codigo = "A123456",
                    Nome = "Andre Teste",
                    DataNascimento = new DateOnly(1991, 1, 1)
                }
            );

            //Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.Nome.ShouldBe("Andre Teste");
        }

        [Fact]
        public async Task Should_Not_Create_A_Cliente_Without_Name()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _clienteAppService.CreateAsync(
                    new CreateUpdateClienteDto
                    {
                        Codigo = "A123456",
                        Nome = "",
                        DataNascimento = new DateOnly(1991, 1, 1)
                    }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "Nome"));
        }

    }
}
