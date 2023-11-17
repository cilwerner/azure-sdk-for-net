// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleManagementPolicyAssignmentResource" /> and their operations.
    /// Each <see cref="RoleManagementPolicyAssignmentResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleManagementPolicyAssignmentCollection" /> instance call the GetRoleManagementPolicyAssignments method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleManagementPolicyAssignmentCollection : ArmCollection, IEnumerable<RoleManagementPolicyAssignmentResource>, IAsyncEnumerable<RoleManagementPolicyAssignmentResource>
    {
        private readonly ClientDiagnostics _roleManagementPolicyAssignmentClientDiagnostics;
        private readonly RoleManagementPolicyAssignmentsRestOperations _roleManagementPolicyAssignmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleManagementPolicyAssignmentCollection"/> class for mocking. </summary>
        protected RoleManagementPolicyAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleManagementPolicyAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleManagementPolicyAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleManagementPolicyAssignmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleManagementPolicyAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleManagementPolicyAssignmentResource.ResourceType, out string roleManagementPolicyAssignmentApiVersion);
            _roleManagementPolicyAssignmentRestClient = new RoleManagementPolicyAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleManagementPolicyAssignmentApiVersion);
        }

        /// <summary>
        /// Create a role management policy assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to upsert. </param>
        /// <param name="data"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleManagementPolicyAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyAssignmentRestClient.CreateAsync(Id, roleManagementPolicyAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<RoleManagementPolicyAssignmentResource>(Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a role management policy assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to upsert. </param>
        /// <param name="data"> Parameters for the role management policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoleManagementPolicyAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string roleManagementPolicyAssignmentName, RoleManagementPolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyAssignmentRestClient.Create(Id, roleManagementPolicyAssignmentName, data, cancellationToken);
                var operation = new AuthorizationArmOperation<RoleManagementPolicyAssignmentResource>(Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role management policy assignment for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public virtual async Task<Response<RoleManagementPolicyAssignmentResource>> GetAsync(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyAssignmentRestClient.GetAsync(Id, roleManagementPolicyAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role management policy assignment for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public virtual Response<RoleManagementPolicyAssignmentResource> Get(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyAssignmentRestClient.Get(Id, roleManagementPolicyAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role management assignment policies for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleManagementPolicyAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleManagementPolicyAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleManagementPolicyAssignmentRestClient.CreateListForScopeRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleManagementPolicyAssignmentRestClient.CreateListForScopeNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoleManagementPolicyAssignmentResource(Client, RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(e)), _roleManagementPolicyAssignmentClientDiagnostics, Pipeline, "RoleManagementPolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets role management assignment policies for a resource scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleManagementPolicyAssignmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleManagementPolicyAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleManagementPolicyAssignmentRestClient.CreateListForScopeRequest(Id);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleManagementPolicyAssignmentRestClient.CreateListForScopeNextPageRequest(nextLink, Id);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoleManagementPolicyAssignmentResource(Client, RoleManagementPolicyAssignmentData.DeserializeRoleManagementPolicyAssignmentData(e)), _roleManagementPolicyAssignmentClientDiagnostics, Pipeline, "RoleManagementPolicyAssignmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyAssignmentRestClient.GetAsync(Id, roleManagementPolicyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyAssignmentRestClient.Get(Id, roleManagementPolicyAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<RoleManagementPolicyAssignmentResource>> GetIfExistsAsync(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _roleManagementPolicyAssignmentRestClient.GetAsync(Id, roleManagementPolicyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RoleManagementPolicyAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        public virtual NullableResponse<RoleManagementPolicyAssignmentResource> GetIfExists(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleManagementPolicyAssignmentName, nameof(roleManagementPolicyAssignmentName));

            using var scope = _roleManagementPolicyAssignmentClientDiagnostics.CreateScope("RoleManagementPolicyAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _roleManagementPolicyAssignmentRestClient.Get(Id, roleManagementPolicyAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RoleManagementPolicyAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new RoleManagementPolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleManagementPolicyAssignmentResource> IEnumerable<RoleManagementPolicyAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleManagementPolicyAssignmentResource> IAsyncEnumerable<RoleManagementPolicyAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
