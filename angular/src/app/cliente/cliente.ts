import { ListService, PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, inject } from '@angular/core';
import { ClienteService, ClienteDto } from '../proxy/clientes';

@Component({
  selector: 'app-cliente',
  imports: [],
  templateUrl: './cliente.html',
  styleUrl: './cliente.scss',
})
export class Cliente {
  cliente = { items: [], totalCount: 0 } as PagedResultDto<ClienteDto>;

  public readonly list = inject(ListService); 
  private readonly clienteService = inject(ClienteService);

  ngOnInit() {
    const clienteStreamCreator = (query: PagedAndSortedResultRequestDto) => this.clienteService.getList(query);

    this.list.hookToQuery(clienteStreamCreator).subscribe((response) => {
      this.cliente  = response;
    });
  }
}
