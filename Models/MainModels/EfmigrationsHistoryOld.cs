using System;
using System.Collections.Generic;

namespace CleanWebAPI.Models.MainModels;

public partial class EfmigrationsHistoryOld
{
    public string MigrationId { get; set; } = null!;

    public string ProductVersion { get; set; } = null!;
}
