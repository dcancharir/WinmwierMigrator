using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

public partial class software_validation
{
    [Key]
    public long sval_validation_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime sval_inserted { get; set; }

    public int? sval_terminal_id { get; set; }

    public int? sval_method { get; set; }

    [StringLength(50)]
    public string? sval_seed { get; set; }

    [StringLength(50)]
    public string? sval_expected_signature { get; set; }

    public int sval_status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sval_last_request { get; set; }

    public int? sval_received_status { get; set; }

    [StringLength(50)]
    public string? sval_received_signature { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? sval_received_datetime { get; set; }
}
