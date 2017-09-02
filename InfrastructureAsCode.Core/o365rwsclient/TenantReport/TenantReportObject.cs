﻿using System.Xml;
using System.Xml.Serialization;

namespace InfrastructureAsCode.Core.o365rwsclient.TenantReport
{
    public class TenantReportObject : ReportObject
    {
        [XmlElement]
        public string TenantGuid
        {
            get;
            set;
        }

        [XmlElement]
        public string TenantName
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="node"></param>
        public override void LoadFromXml(XmlNode node)
        {
            base.LoadFromXml(node);

            TenantGuid = base.TryGetValue("TenantGuid");
            TenantName = base.TryGetValue("TenantName");
        }
    }
}