using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("adt_fechaJornada", "adt_IdMaquina", "adt_secuencia")]
[Table("AFIP_DETALLE_TERMINALES")]
public partial class AFIP_DETALLE_TERMINALE
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime adt_fechaJornada { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string adt_IdMaquina { get; set; } = null!;

    [Key]
    public int adt_secuencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? adt_fechaHoraSecuenciaInicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? adt_fechaHoraSecuenciaFin { get; set; }

    [Column(TypeName = "numeric(18, 4)")]
    public decimal? adt_Denominacion { get; set; }

    public long? adt_ContJuegosIni { get; set; }

    public long? adt_ContCoinInIni { get; set; }

    public long? adt_ContCoinOutIni { get; set; }

    public long? adt_ContJackpotIni { get; set; }

    public long? adt_ContJuegosFin { get; set; }

    public long? adt_ContCoinInFin { get; set; }

    public long? adt_ContCoinOutFin { get; set; }

    public long? adt_ContJackpotFin { get; set; }

    public int adt_terminal_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime adt_created_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? adt_last_updated { get; set; }

    [StringLength(250)]
    public string? adt_comment { get; set; }

    public int? adt_last_updated_user_id { get; set; }
}
