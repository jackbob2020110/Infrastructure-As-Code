﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAsCode.Core.Reports.o365Graph.TenantReport
{
    public class OneDriveActivityDetail
    {
        public DateTime ReportRefreshDate { get; set; }

        public DateTime LastActivityDateUTC { get; set; }

        public string UPN { get; set; }

        public string Deleted { get; set; }

        public Nullable<DateTime> DeletedDate { get; set; }

        public Int32 FilesViewedModified { get; set; }

        public Int32 SyncedFileCount { get; set; }

        public Int64 SharedInternallyFileCount { get; set; }

        public Int64 SharedExternallyFileCount { get; set; }

        public string ProductsAssigned { get; set; }

        public int ReportPeriod { get; set; }
    }
}
