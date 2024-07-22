using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

[Table("chips_stock")]
public partial class chips_stock
{
    [Key]
    public long chsk_chip_id { get; set; }

    public int? chsk_quantity { get; set; }
}
