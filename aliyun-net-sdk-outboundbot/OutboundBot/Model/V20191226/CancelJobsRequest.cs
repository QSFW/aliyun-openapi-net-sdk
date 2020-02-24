/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class CancelJobsRequest : RpcAcsRequest<CancelJobsResponse>
    {
        public CancelJobsRequest()
            : base("OutboundBot", "2019-12-26", "CancelJobs", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private bool? all;

		private List<string> jobReferenceIds = new List<string>(){ };

		private List<string> jobIds = new List<string>(){ };

		private string instanceId;

		private string jobGroupId;

		private string scenarioId;

		public bool? All
		{
			get
			{
				return all;
			}
			set	
			{
				all = value;
				DictionaryUtil.Add(QueryParameters, "All", value.ToString());
			}
		}

		public List<string> JobReferenceIds
		{
			get
			{
				return jobReferenceIds;
			}

			set
			{
				jobReferenceIds = value;
				for (int i = 0; i < jobReferenceIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"JobReferenceId." + (i + 1) , jobReferenceIds[i]);
				}
			}
		}

		public List<string> JobIds
		{
			get
			{
				return jobIds;
			}

			set
			{
				jobIds = value;
				for (int i = 0; i < jobIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"JobId." + (i + 1) , jobIds[i]);
				}
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string JobGroupId
		{
			get
			{
				return jobGroupId;
			}
			set	
			{
				jobGroupId = value;
				DictionaryUtil.Add(QueryParameters, "JobGroupId", value);
			}
		}

		public string ScenarioId
		{
			get
			{
				return scenarioId;
			}
			set	
			{
				scenarioId = value;
				DictionaryUtil.Add(QueryParameters, "ScenarioId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CancelJobsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CancelJobsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}