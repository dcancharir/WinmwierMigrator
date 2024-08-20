using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class junkets_flyer
{
    public long jf_id { get; set; }

    public long jf_junket_id { get; set; }

    public long? jf_promotion_id { get; set; }

    [StringLength(12)]
    public string jf_code { get; set; } = null!;

    public int? jf_num_created { get; set; }

    public bool jf_allow_reuse { get; set; }

    [StringLength(1024)]
    public string? jf_comment { get; set; }

    public bool jf_show_pop_up { get; set; }

    [StringLength(512)]
    public string? jf_text_pop_up { get; set; }

    public bool jf_print_voucher { get; set; }

    [StringLength(100)]
    public string? jf_title_voucher { get; set; }

    [StringLength(100)]
    public string? jf_text_voucher { get; set; }

    public bool jf_print_text_promotion { get; set; }

    [StringLength(100)]
    public string? jf_text_promotion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jf_creation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime jf_update { get; set; }
}
