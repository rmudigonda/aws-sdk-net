/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
    using System.Collections.Generic;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Result Unmarshaller for ListClosedWorkflowExecutions operation
      /// </summary>
      internal class ListClosedWorkflowExecutionsResultUnmarshaller : IUnmarshaller<ListClosedWorkflowExecutionsResult, JsonUnmarshallerContext>
      {
        public ListClosedWorkflowExecutionsResult Unmarshall(JsonUnmarshallerContext context)
        {
          ListClosedWorkflowExecutionsResult result = new ListClosedWorkflowExecutionsResult();
          result.WorkflowExecutionInfos = WorkflowExecutionInfosUnmarshaller.GetInstance().Unmarshall(context);
          return result;
        }

        private static ListClosedWorkflowExecutionsResultUnmarshaller instance;
        public static ListClosedWorkflowExecutionsResultUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new ListClosedWorkflowExecutionsResultUnmarshaller();
          }
          return instance;
        }
      }
    }
  