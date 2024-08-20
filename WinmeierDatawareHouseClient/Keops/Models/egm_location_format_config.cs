using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
[Table("egm_location_format_config")]
public partial class egm_location_format_config
{
    public int elfc_id { get; set; }

    public short elfc_area_id { get; set; }

    public bool elfc_area_id_separator { get; set; }

    public short elfc_area_name { get; set; }

    public bool elfc_area_name_separator { get; set; }

    public short elfc_zone { get; set; }

    public bool elfc_zone_separator { get; set; }

    public short elfc_bank_id { get; set; }

    public bool elfc_bank_id_separator { get; set; }

    public short elfc_bank_name { get; set; }

    public bool elfc_bank_name_separator { get; set; }

    public short elfc_position { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime elfc_last_update { get; set; }
}
