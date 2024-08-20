using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class mapp_image
{
    public long im_image_id { get; set; }

    [StringLength(100)]
    public string? im_content_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime im_created_date { get; set; }

    public string? im_file_name { get; set; }

    [StringLength(100)]
    public string? im_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime im_updated_date { get; set; }

    [MaxLength(1)]
    public byte[]? im_data { get; set; }
}
