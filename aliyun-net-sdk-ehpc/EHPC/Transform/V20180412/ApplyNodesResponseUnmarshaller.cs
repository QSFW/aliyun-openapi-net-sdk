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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ApplyNodesResponseUnmarshaller
    {
        public static ApplyNodesResponse Unmarshall(UnmarshallerContext context)
        {
			ApplyNodesResponse applyNodesResponse = new ApplyNodesResponse();

			applyNodesResponse.HttpResponse = context.HttpResponse;
			applyNodesResponse.RequestId = context.StringValue("ApplyNodes.RequestId");
			applyNodesResponse.Detail = context.StringValue("ApplyNodes.Detail");
			applyNodesResponse.SatisfiedAmount = context.IntegerValue("ApplyNodes.SatisfiedAmount");
			applyNodesResponse.TaskId = context.StringValue("ApplyNodes.TaskId");

			List<string> applyNodesResponse_instanceIds = new List<string>();
			for (int i = 0; i < context.Length("ApplyNodes.InstanceIds.Length"); i++) {
				applyNodesResponse_instanceIds.Add(context.StringValue("ApplyNodes.InstanceIds["+ i +"]"));
			}
			applyNodesResponse.InstanceIds = applyNodesResponse_instanceIds;
        
			return applyNodesResponse;
        }
    }
}
