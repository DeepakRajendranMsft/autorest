// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsUrlMultiCollectionFormat
{
    using Models;

    /// <summary>
    /// Queries operations.
    /// </summary>
    public partial interface IQueries
    {
        /// <summary>
        /// Get a null array of string using the multi-array format
        /// </summary>
        /// <param name='arrayQuery'>
        /// a null array of string using the multi-array format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ArrayStringMultiNullWithHttpMessagesAsync(System.Collections.Generic.IList<string> arrayQuery = default(System.Collections.Generic.IList<string>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get an empty array [] of string using the multi-array format
        /// </summary>
        /// <param name='arrayQuery'>
        /// an empty array [] of string using the multi-array format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ArrayStringMultiEmptyWithHttpMessagesAsync(System.Collections.Generic.IList<string> arrayQuery = default(System.Collections.Generic.IList<string>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get an array of string ['ArrayQuery1', 'begin!*'();:@
        /// &amp;=+$,/?#[]end' , null, ''] using the mult-array format
        /// </summary>
        /// <param name='arrayQuery'>
        /// an array of string ['ArrayQuery1', 'begin!*'();:@
        /// &amp;=+$,/?#[]end' , null, ''] using the mult-array format
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ArrayStringMultiValidWithHttpMessagesAsync(System.Collections.Generic.IList<string> arrayQuery = default(System.Collections.Generic.IList<string>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
