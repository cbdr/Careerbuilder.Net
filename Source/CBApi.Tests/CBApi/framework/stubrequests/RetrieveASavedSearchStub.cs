﻿using CBApi;
using CBApi.Framework.Requests;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tests.CBApi.models.service;

namespace Tests.com.careerbuilder.CBApi.framework.stubrequests
{
    public class RetrieveASavedSearchStub:RetrieveASavedSearch
    {
        public RetrieveASavedSearchStub(string key, string domain, string cobrand, string siteid, int timeout, string savedSearchDID)
            : base(new APISettings()
            {
                DevKey = key,
                CobrandCode = cobrand,
                SiteId = siteid,
                TargetSite = new TargetSiteMock(domain),
                TimeoutMS = timeout
            }, savedSearchDID) { }

        public IRestClient Client { get { return _client; } set { _client = value; } }
        public IRestRequest Request { get { return _request; } set { _request = value; } }
    }
}
