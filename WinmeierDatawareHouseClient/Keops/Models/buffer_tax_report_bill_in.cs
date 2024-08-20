using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[PrimaryKey("btxbi_id", "btxbi_timestamp")]
[Table("buffer_tax_report_bill_in")]
public partial class buffer_tax_report_bill_in
{
    [Key]
    public long btxbi_id { get; set; }

    [Key]
    [Column(TypeName = "datetime")]
    public DateTime btxbi_timestamp { get; set; }
}
