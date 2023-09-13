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
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A Class representing a VirtualMachineScaleSetVmExtension along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="VirtualMachineScaleSetVmExtensionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetVirtualMachineScaleSetVmExtensionResource method.
    /// Otherwise you can get one from its parent resource <see cref="VirtualMachineScaleSetVmResource" /> using the GetVirtualMachineScaleSetVmExtension method.
    /// </summary>
    [DeserializationProxy(typeof(VirtualMachineScaleSetVmExtensionData))]
    public partial class VirtualMachineScaleSetVmExtensionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="VirtualMachineScaleSetVmExtensionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string virtualMachineScaleSetName, string instanceId, string vmExtensionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{virtualMachineScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics;
        private readonly VirtualMachineScaleSetVMExtensionsRestOperations _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient;
        private readonly VirtualMachineScaleSetVmExtensionData _data;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVmExtensionResource"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVmExtensionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualMachineScaleSetVmExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal VirtualMachineScaleSetVmExtensionResource(ArmClient client, VirtualMachineScaleSetVmExtensionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVmExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal VirtualMachineScaleSetVmExtensionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsApiVersion);
            _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient = new VirtualMachineScaleSetVMExtensionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/virtualMachineScaleSets/virtualMachines/extensions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual VirtualMachineScaleSetVmExtensionData Data
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
        /// The operation to get the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualMachineScaleSetVmExtensionResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmExtensionResource.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVmExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualMachineScaleSetVmExtensionResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmExtensionResource.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVmExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmExtensionResource.Delete");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation(_virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to delete the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmExtensionResource.Delete");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ComputeArmOperation(_virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to update the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineScaleSetVmExtensionResource>> UpdateAsync(WaitUntil waitUntil, VirtualMachineScaleSetVmExtensionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmExtensionResource.Update");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<VirtualMachineScaleSetVmExtensionResource>(new VirtualMachineScaleSetVmExtensionOperationSource(Client), _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to update the VMSS VM extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/extensions/{vmExtensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineScaleSetVMExtensions_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> Parameters supplied to the Update Virtual Machine Extension operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineScaleSetVmExtensionResource> Update(WaitUntil waitUntil, VirtualMachineScaleSetVmExtensionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics.CreateScope("VirtualMachineScaleSetVmExtensionResource.Update");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch, cancellationToken);
                var operation = new ComputeArmOperation<VirtualMachineScaleSetVmExtensionResource>(new VirtualMachineScaleSetVmExtensionOperationSource(Client), _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsClientDiagnostics, Pipeline, _virtualMachineScaleSetVmExtensionVirtualMachineScaleSetVmExtensionsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, patch).Request, response, OperationFinalStateVia.Location);
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
    }
}
