﻿using InfrastructureAsCode.Core.Reports.o365Graph.TenantReport;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAsCode.Powershell.Commands.Reporting.Usage
{
    /*
     * 
Report Refresh Date,
Site Type,
Total,
Active,
Report Date,
Report Period
2017-10-29,All,860,65,2017-10-29,90
2017-10-29,All,860,72,2017-10-28,90
     */
    class SharePointSiteUsageSiteCountsMap : ClassMap<SharePointSiteUsageSiteCounts>
    {
        public SharePointSiteUsageSiteCountsMap()
        {
            Map(m => m.ReportRefreshDate).Name("Report Refresh Date").Index(0).Default(default(DateTime));
            Map(m => m.SiteType).Name("Site Type").Index(1).Default(string.Empty);
            Map(m => m.Total).Name("Total").Index(2).Default(0);
            Map(m => m.Active).Name("Active").Index(3).Default(0);
            Map(m => m.ReportDate).Name("Report Date").Index(4).Default(default(DateTime));
            Map(m => m.ReportPeriod).Name("Report Period").Index(5).Default(0);
        }
    }
}