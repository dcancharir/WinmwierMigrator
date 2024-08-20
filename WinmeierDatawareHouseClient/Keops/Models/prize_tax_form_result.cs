using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("prize_tax_form_result")]
public partial class prize_tax_form_result
{
    public long ptfr_id { get; set; }

    public long ptfr_process_id { get; set; }

    public long ptfr_account_id { get; set; }

    [Column(TypeName = "money")]
    public decimal ptfr_amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ptfr_last_print_datetime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ptfr_last_efile_datetime { get; set; }
}
