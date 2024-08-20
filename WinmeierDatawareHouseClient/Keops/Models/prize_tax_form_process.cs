using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("prize_tax_form_process")]
public partial class prize_tax_form_process
{
    public long ptfp_id { get; set; }

    public long ptfp_site_process_id { get; set; }

    public int ptfp_year { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ptfp_execution_datetime { get; set; }

    public int ptfp_status { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ptfp_status_message { get; set; }

    public int? ptfp_requester_site_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ptfp_end_datetime { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? ptfp_output_message { get; set; }
}
