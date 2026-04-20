import { CoreModule, ListService, PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { ModalCloseDirective, ModalComponent, NgxDatatableDefaultDirective, NgxDatatableListDirective, ConfirmationService,Confirmation } from '@abp/ng.theme.shared';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { Component, OnInit, inject } from '@angular/core';
import { DatatableComponent, NgxDatatableModule } from '@swimlane/ngx-datatable';
import { ClienteService, ClienteDto } from '../proxy/clientes';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-cliente',
  imports: [CoreModule, DatatableComponent, NgxDatatableModule, NgxDatatableListDirective, NgxDatatableDefaultDirective, ModalComponent, ModalCloseDirective, NgbDropdownModule],
  providers: [ListService],
  templateUrl: './cliente.html',
  styleUrl: './cliente.scss',
})
export class Cliente implements OnInit {
  cliente = { items: [], totalCount: 0 } as PagedResultDto<ClienteDto>;
  selectedCliente = {} as ClienteDto;
  form!: FormGroup;

  isModalOpen = false;

  public readonly list = inject(ListService); 
  private readonly clienteService = inject(ClienteService);
  private readonly fb = inject(FormBuilder);
  private readonly confirmation = inject(ConfirmationService);

  ngOnInit() {
    const clienteStreamCreator = (query: PagedAndSortedResultRequestDto) => this.clienteService.getList(query);

    this.list.hookToQuery(clienteStreamCreator).subscribe((response) => {
      this.cliente  = response;
    });
  }

  createCliente() {
    this.selectedCliente = {} as ClienteDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editCliente(id: string) {
    this.clienteService.get(id).subscribe((cliente) => {
      this.selectedCliente = cliente;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.clienteService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  buildForm() {
    this.form = this.fb.group({
      codigo: [this.selectedCliente.codigo || '', Validators.required],
      nome: [this.selectedCliente.nome || '', Validators.required],
      dataNascimento: [this.selectedCliente.dataNascimento || '', Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedCliente.id
      ? this.clienteService.update(this.selectedCliente.id, this.form.value)
      : this.clienteService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}
