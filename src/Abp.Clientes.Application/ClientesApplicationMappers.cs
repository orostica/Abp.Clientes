using Abp.Clientes.Clientes;
using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;

namespace Abp.Clientes;

/*
 * You can add your own mappings here.
 * [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
 * public partial class ClientesApplicationMappers : MapperBase<BookDto, CreateUpdateBookDto>
 * {
 *    public override partial CreateUpdateBookDto Map(BookDto source);
 * 
 *    public override partial void Map(BookDto source, CreateUpdateBookDto destination);
 * }
 */
[Mapper]
public partial class ClienteToClienteDtoMapper : MapperBase<Cliente, ClienteDto>
{
    public override partial ClienteDto Map(Cliente source);
    public override partial void Map(Cliente source, ClienteDto destination);
}

[Mapper]
public partial class CreateUpdateClienteDtoToClienteMapper : MapperBase<CreateUpdateClienteDto, Cliente>
{
    public override partial Cliente Map(CreateUpdateClienteDto source);
    public override partial void Map(CreateUpdateClienteDto source, Cliente destination);
}