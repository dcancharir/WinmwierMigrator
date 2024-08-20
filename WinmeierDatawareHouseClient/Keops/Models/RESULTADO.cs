using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("RESULTADOS")]
public partial class RESULTADO
{
    [StringLength(280)]
    public string? ACTION { get; set; }

    public int? IND_SZE { get; set; }

    public int? DATA { get; set; }

    public int? RES { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? FRAG { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FECHA { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string COMENTARIO { get; set; } = null!;
}
