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
Page View Count,
Report Date,
Report Period
2017-10-29,All,1335,2017-10-29,7
 */
    class SharePointSiteUsagePagesMap : ClassMap<SharePointSiteUsagePages>
    {
        public SharePointSiteUsagePagesMap()
        {
            Map(m => m.ReportRefreshDate).Name("Report Refresh Date").Index(0).Default(default(DateTime));
            Map(m => m.SiteType).Name("Site Type").Index(1).Default(string.Empty);
            Map(m => m.PageViewCount).Name("Page View Count").Index(2).Default(string.Empty);
            Map(m => m.ReportDate).Name("Report Date").Index(3).Default(default(DateTime));
            Map(m => m.ReportPeriod).Name("Report Period").Index(4).Default(0);
        }
    }
}