using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Models;

public partial class mapp_image
{
    [Key]
    public long im_image_id { get; set; }

    [StringLength(50)]
    public string? im_content_type { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime im_created_date { get; set; }

    public string? im_file_name { get; set; }

    [StringLength(50)]
    public string? im_name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime im_updated_date { get; set; }

    public byte[]? im_data { get; set; }
}
