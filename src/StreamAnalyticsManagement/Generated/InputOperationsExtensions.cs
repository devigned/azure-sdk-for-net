// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics
{
    public static partial class InputOperationsExtensions
    {
        /// <summary>
        /// Test the connectivity of an input for a stream analytics job.
        /// Asynchronous call.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The input name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static DataSourceTestConnectionResponse BeginTestConnection(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).BeginTestConnectionAsync(resourceGroupName, jobName, inputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Test the connectivity of an input for a stream analytics job.
        /// Asynchronous call.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The input name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static Task<DataSourceTestConnectionResponse> BeginTestConnectionAsync(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return operations.BeginTestConnectionAsync(resourceGroupName, jobName, inputName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an input for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the input CreateOrUpdate operation.
        /// </returns>
        public static InputCreateOrUpdateResponse CreateOrUpdate(this IInputOperations operations, string resourceGroupName, string jobName, InputCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).CreateOrUpdateAsync(resourceGroupName, jobName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an input for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the input CreateOrUpdate operation.
        /// </returns>
        public static Task<InputCreateOrUpdateResponse> CreateOrUpdateAsync(this IInputOperations operations, string resourceGroupName, string jobName, InputCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, jobName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update an input for a stream analytics job. The raw json
        /// content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an input for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the input CreateOrUpdate operation.
        /// </returns>
        public static InputCreateOrUpdateResponse CreateOrUpdateWithRawJsonContent(this IInputOperations operations, string resourceGroupName, string jobName, string inputName, InputCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, inputName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update an input for a stream analytics job. The raw json
        /// content will be used.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update an input for
        /// a stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the input CreateOrUpdate operation.
        /// </returns>
        public static Task<InputCreateOrUpdateResponse> CreateOrUpdateWithRawJsonContentAsync(this IInputOperations operations, string resourceGroupName, string jobName, string inputName, InputCreateOrUpdateWithRawJsonContentParameters parameters)
        {
            return operations.CreateOrUpdateWithRawJsonContentAsync(resourceGroupName, jobName, inputName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <returns>
        /// The common operation response.
        /// </returns>
        public static CommonOperationResponse Delete(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).DeleteAsync(resourceGroupName, jobName, inputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <returns>
        /// The common operation response.
        /// </returns>
        public static Task<CommonOperationResponse> DeleteAsync(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return operations.DeleteAsync(resourceGroupName, jobName, inputName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the get stream analytics intput operation.
        /// </returns>
        public static InputGetResponse Get(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).GetAsync(resourceGroupName, jobName, inputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the get stream analytics intput operation.
        /// </returns>
        public static Task<InputGetResponse> GetAsync(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return operations.GetAsync(resourceGroupName, jobName, inputName, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of the inputs defined in a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the input list operation.
        /// </returns>
        public static InputListResponse ListInputInJob(this IInputOperations operations, string resourceGroupName, string jobName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).ListInputInJobAsync(resourceGroupName, jobName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of the inputs defined in a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The response of the input list operation.
        /// </returns>
        public static Task<InputListResponse> ListInputInJobAsync(this IInputOperations operations, string resourceGroupName, string jobName)
        {
            return operations.ListInputInJobAsync(resourceGroupName, jobName, CancellationToken.None);
        }
        
        /// <summary>
        /// Update an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to update an input for a stream
        /// analytics job.
        /// </param>
        /// <returns>
        /// The response of the input patch operation.
        /// </returns>
        public static InputPatchResponse Patch(this IInputOperations operations, string resourceGroupName, string jobName, string inputName, InputPatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).PatchAsync(resourceGroupName, jobName, inputName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The name of the input for the stream analytics job.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to update an input for a stream
        /// analytics job.
        /// </param>
        /// <returns>
        /// The response of the input patch operation.
        /// </returns>
        public static Task<InputPatchResponse> PatchAsync(this IInputOperations operations, string resourceGroupName, string jobName, string inputName, InputPatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, jobName, inputName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Test the connectivity of an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The input name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static DataSourceTestConnectionResponse TestConnection(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IInputOperations)s).TestConnectionAsync(resourceGroupName, jobName, inputName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Test the connectivity of an input for a stream analytics job.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.StreamAnalytics.IInputOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the stream analytics job.
        /// </param>
        /// <param name='jobName'>
        /// Required. The name of the stream analytics job.
        /// </param>
        /// <param name='inputName'>
        /// Required. The input name of the stream analytics job.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        public static Task<DataSourceTestConnectionResponse> TestConnectionAsync(this IInputOperations operations, string resourceGroupName, string jobName, string inputName)
        {
            return operations.TestConnectionAsync(resourceGroupName, jobName, inputName, CancellationToken.None);
        }
    }
}
