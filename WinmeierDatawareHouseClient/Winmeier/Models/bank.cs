using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Winmeier.Models;

[Index("bk_area_id", Name = "IX_banks_bk_area_id")]
[Index("bk_name", Name = "IX_bk_name", IsUnique = true)]
public partial class bank
{
    [Key]
	//[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int bk_bank_id { get; set; }

    public int bk_area_id { get; set; }

    [StringLength(50)]
    public string bk_name { get; set; } = null!;
	//[Timestamp]
	public byte[]? bk_timestamp { get; set; }
}
