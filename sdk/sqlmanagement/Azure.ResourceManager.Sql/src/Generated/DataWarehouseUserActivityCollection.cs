// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="DataWarehouseUserActivityResource" /> and their operations.
    /// Each <see cref="DataWarehouseUserActivityResource" /> in the collection will belong to the same instance of <see cref="SqlDatabaseResource" />.
    /// To get a <see cref="DataWarehouseUserActivityCollection" /> instance call the GetDataWarehouseUserActivities method from an instance of <see cref="SqlDatabaseResource" />.
    /// </summary>
    public partial class DataWarehouseUserActivityCollection : ArmCollection, IEnumerable<DataWarehouseUserActivityResource>, IAsyncEnumerable<DataWarehouseUserActivityResource>
    {
        private readonly ClientDiagnostics _dataWarehouseUserActivityClientDiagnostics;
        private readonly DataWarehouseUserActivitiesRestOperations _dataWarehouseUserActivityRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataWarehouseUserActivityCollection"/> class for mocking. </summary>
        protected DataWarehouseUserActivityCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataWarehouseUserActivityCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataWarehouseUserActivityCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataWarehouseUserActivityClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", DataWarehouseUserActivityResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataWarehouseUserActivityResource.ResourceType, out string dataWarehouseUserActivityApiVersion);
            _dataWarehouseUserActivityRestClient = new DataWarehouseUserActivitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataWarehouseUserActivityApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the user activities of a data warehouse which includes running and suspended queries
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataWarehouseUserActivityResource>> GetAsync(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataWarehouseUserActivityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the user activities of a data warehouse which includes running and suspended queries
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataWarehouseUserActivityResource> Get(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityCollection.Get");
            scope.Start();
            try
            {
                var response = _dataWarehouseUserActivityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the user activities of a data warehouse which includes running and suspended queries
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataWarehouseUserActivityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataWarehouseUserActivityResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataWarehouseUserActivityRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataWarehouseUserActivityRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataWarehouseUserActivityResource(Client, DataWarehouseUserActivityData.DeserializeDataWarehouseUserActivityData(e)), _dataWarehouseUserActivityClientDiagnostics, Pipeline, "DataWarehouseUserActivityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the user activities of a data warehouse which includes running and suspended queries
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_ListByDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataWarehouseUserActivityResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataWarehouseUserActivityResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataWarehouseUserActivityRestClient.CreateListByDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataWarehouseUserActivityRestClient.CreateListByDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataWarehouseUserActivityResource(Client, DataWarehouseUserActivityData.DeserializeDataWarehouseUserActivityData(e)), _dataWarehouseUserActivityClientDiagnostics, Pipeline, "DataWarehouseUserActivityCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataWarehouseUserActivityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataWarehouseUserActivityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<DataWarehouseUserActivityResource>> GetIfExistsAsync(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataWarehouseUserActivityRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataWarehouseUserActivityResource>(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivityResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/dataWarehouseUserActivities/{dataWarehouseUserActivityName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DataWarehouseUserActivities_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dataWarehouseUserActivityName"> The activity name of the data warehouse. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<DataWarehouseUserActivityResource> GetIfExists(DataWarehouseUserActivityName dataWarehouseUserActivityName, CancellationToken cancellationToken = default)
        {
            using var scope = _dataWarehouseUserActivityClientDiagnostics.CreateScope("DataWarehouseUserActivityCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataWarehouseUserActivityRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, dataWarehouseUserActivityName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataWarehouseUserActivityResource>(response.GetRawResponse());
                return Response.FromValue(new DataWarehouseUserActivityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataWarehouseUserActivityResource> IEnumerable<DataWarehouseUserActivityResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataWarehouseUserActivityResource> IAsyncEnumerable<DataWarehouseUserActivityResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
