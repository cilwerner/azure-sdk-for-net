// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.Serialization;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A Class representing a CloudServiceRole along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CloudServiceRoleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCloudServiceRoleResource method.
    /// Otherwise you can get one from its parent resource <see cref="CloudServiceResource" /> using the GetCloudServiceRole method.
    /// </summary>
    [DeserializationProxy(typeof(CloudServiceRoleData))]
    public partial class CloudServiceRoleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CloudServiceRoleResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string cloudServiceName, string roleName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roles/{roleName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cloudServiceRoleClientDiagnostics;
        private readonly CloudServiceRolesRestOperations _cloudServiceRoleRestClient;
        private readonly CloudServiceRoleData _data;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRoleResource"/> class for mocking. </summary>
        protected CloudServiceRoleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CloudServiceRoleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CloudServiceRoleResource(ArmClient client, CloudServiceRoleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRoleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CloudServiceRoleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudServiceRoleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cloudServiceRoleApiVersion);
            _cloudServiceRoleRestClient = new CloudServiceRolesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudServiceRoleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/cloudServices/roles";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CloudServiceRoleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a role from a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CloudServiceRoleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceRoleClientDiagnostics.CreateScope("CloudServiceRoleResource.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceRoleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a role from a cloud service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}/roles/{roleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudServiceRoles_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CloudServiceRoleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cloudServiceRoleClientDiagnostics.CreateScope("CloudServiceRoleResource.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceRoleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRoleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
