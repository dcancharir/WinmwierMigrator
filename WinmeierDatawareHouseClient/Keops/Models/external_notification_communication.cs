using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinmeierDataWarehouseClient.Keops.Models;

[Keyless]
public partial class external_notification_communication
{
    public long enc_id { get; set; }

    public long enc_notification_id { get; set; }

    public bool enc_sent { get; set; }

    public int enc_retry_number { get; set; }

    public string enc_data_request { get; set; } = null!;

    public string enc_data_response { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime enc_created_datetime { get; set; }
}
