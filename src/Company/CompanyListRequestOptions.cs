﻿using Skarp.HubSpotClient.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Skarp.HubSpotClient.Company
{
    [DataContract]
    public class CompanySearchByDomain
    {
        [DataMember(Name = "limit")]
        public int Limit { get; set; } = 100;

        [DataMember(Name = "requestOptions")]
        public CompanySearchRequestOptions RequestOptions { get; set; } = new CompanySearchRequestOptions();

        [DataMember(Name = "offset")]
        public CompanySearchOffset Offset { get; set; } = new CompanySearchOffset();

        public string RouteBasePath => "/companies/v2";
        public bool IsNameValue => true;
        public void AcceptHubSpotDataEntity(ref object converted)
        {

        }
    }

    [DataContract]
    public class CompanySearchRequestOptions
    {
        [DataMember(Name = "properties")]
        public List<string> Properties { get; set; } = new List<string> { "domain", "name", "website" };
    }

    [DataContract]
    public class CompanySearchOffset
    {

        [DataMember(Name = "isPrimary")]
        public bool IsPrimary { get; set; } = true;

        [DataMember(Name = "companyId")]
        public long CompanyId { get; set; } = 0;
    }

}
