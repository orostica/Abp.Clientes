import type { AuditedEntityDto } from '@abp/ng.core';

export interface ClienteDto extends AuditedEntityDto<string> {
  codigo?: string;
  nome?: string;
  dataNascimento?: string;
}

export interface CreateUpdateClienteDto {
  codigo: string;
  nome: string;
  dataNascimento: string;
}
