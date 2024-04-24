using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RangoAgil.API.Entities;

public class Rango
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public required string Nome { get; set; }

    public ICollection<Ingrediente> Ingredientes { get; set; } = [];

    public Rango()
    {

    }

    [SetsRequiredMembers]
    public Rango(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}
