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
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing a MachineLearningLabelingJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MachineLearningLabelingJobResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMachineLearningLabelingJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningWorkspaceResource" /> using the GetMachineLearningLabelingJob method.
    /// </summary>
    public partial class MachineLearningLabelingJobResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MachineLearningLabelingJobResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="id"> The id. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string id)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _machineLearningLabelingJobLabelingJobsClientDiagnostics;
        private readonly LabelingJobsRestOperations _machineLearningLabelingJobLabelingJobsRestClient;
        private readonly MachineLearningLabelingJobData _data;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningLabelingJobResource"/> class for mocking. </summary>
        protected MachineLearningLabelingJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MachineLearningLabelingJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MachineLearningLabelingJobResource(ArmClient client, MachineLearningLabelingJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningLabelingJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningLabelingJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningLabelingJobLabelingJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string machineLearningLabelingJobLabelingJobsApiVersion);
            _machineLearningLabelingJobLabelingJobsRestClient = new LabelingJobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningLabelingJobLabelingJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/labelingJobs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MachineLearningLabelingJobData Data
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
        /// Gets a labeling job by name/id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MachineLearningLabelingJobResource>> GetAsync(bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, includeJobInstructions, includeLabelCategories, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningLabelingJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a labeling job by name/id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MachineLearningLabelingJobResource> Get(bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Get");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, includeJobInstructions, includeLabelCategories, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningLabelingJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a labeling job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Delete");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a labeling job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Delete");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> LabelingJob definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningLabelingJobResource>> UpdateAsync(WaitUntil waitUntil, MachineLearningLabelingJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Update");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningLabelingJobResource>(new MachineLearningLabelingJobOperationSource(Client), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Creates or updates a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> LabelingJob definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningLabelingJobResource> Update(WaitUntil waitUntil, MachineLearningLabelingJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Update");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningLabelingJobResource>(new MachineLearningLabelingJobOperationSource(Client), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Export labels from a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}/exportLabels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_ExportLabels</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="body"> The export summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<ArmOperation<ExportSummary>> ExportLabelsAsync(WaitUntil waitUntil, ExportSummary body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.ExportLabels");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.ExportLabelsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<ExportSummary>(new ExportSummaryOperationSource(), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateExportLabelsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response, OperationFinalStateVia.Location);
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
        /// Export labels from a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}/exportLabels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_ExportLabels</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="body"> The export summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual ArmOperation<ExportSummary> ExportLabels(WaitUntil waitUntil, ExportSummary body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.ExportLabels");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.ExportLabels(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken);
                var operation = new MachineLearningArmOperation<ExportSummary>(new ExportSummaryOperationSource(), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateExportLabelsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response, OperationFinalStateVia.Location);
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
        /// Pause a labeling job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}/pause</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Pause</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PauseAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Pause");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.PauseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Pause a labeling job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}/pause</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Pause</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Pause(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Pause");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.Pause(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resume a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}/resume</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Resume</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> ResumeAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Resume");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.ResumeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(_machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateResumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resume a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}/resume</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Resume</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Resume(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobResource.Resume");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.Resume(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(_machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateResumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
