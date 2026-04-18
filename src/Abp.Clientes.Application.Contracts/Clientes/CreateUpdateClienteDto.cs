using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Abp.Clientes.Clientes;

public class CreateUpdateClienteDto
{
    [Required]
    [StringLength(128)]
    public string Codigo { get; set; } = string.Empty;

    [Required(ErrorMessage = "Nome é obrigatório")]
    [MinLength(3, ErrorMessage = "Nome deve ter pelo menos 3 caracteres")]
    [StringLength(128)]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Data de nascimento é obrigatória")]
    [DataType(DataType.Date)]
    public DateOnly DataNascimento { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var hoje = DateOnly.FromDateTime(DateTime.Today);

        if (DataNascimento > hoje)
        {
            yield return new ValidationResult(
                "A data de nascimento não pode ser maior que hoje.",
                [nameof(DataNascimento)]
            );
            yield break;
        }

        var idade = hoje.Year - DataNascimento.Year;

        if (DataNascimento > hoje.AddYears(-idade))
            idade--;

        if (idade < 18)
        {
            yield return new ValidationResult(
                "É necessário ter pelo menos 18 anos.",
                [nameof(DataNascimento)]
            );
        }
    }
}
