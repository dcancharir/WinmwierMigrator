using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class wsp_authorized_vendor
{
    [Key]
    [StringLength(50)]
    public string wav_vendor_id { get; set; } = null!;

    public bool wav_authorized { get; set; }
}
