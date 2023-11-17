// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Samples
{
    public partial class Sample_SiteRecoveryFabricResource
    {
        // Gets the details of an ASR fabric.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheDetailsOfAnASRFabric()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationFabrics_Get.json
            // this example is just showing the usage of "ReplicationFabrics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // invoke the operation
            SiteRecoveryFabricResource result = await siteRecoveryFabric.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Checks the consistency of the ASR fabric.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckConsistency_ChecksTheConsistencyOfTheASRFabric()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationFabrics_CheckConsistency.json
            // this example is just showing the usage of "ReplicationFabrics_CheckConsistency" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // invoke the operation
            ArmOperation<SiteRecoveryFabricResource> lro = await siteRecoveryFabric.CheckConsistencyAsync(WaitUntil.Completed);
            SiteRecoveryFabricResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Migrates the site to AAD.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task MigrateToAad_MigratesTheSiteToAAD()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationFabrics_MigrateToAad.json
            // this example is just showing the usage of "ReplicationFabrics_MigrateToAad" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // invoke the operation
            await siteRecoveryFabric.MigrateToAadAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Perform failover of the process server.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ReassociateGateway_PerformFailoverOfTheProcessServer()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationFabrics_ReassociateGateway.json
            // this example is just showing the usage of "ReplicationFabrics_ReassociateGateway" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "7c943c1b-5122-4097-90c8-861411bdd574";
            string resourceGroupName = "MadhaviVRG";
            string resourceName = "MadhaviVault";
            string fabricName = "GRACE-V2A-1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // invoke the operation
            FailoverProcessServerContent content = new FailoverProcessServerContent()
            {
                Properties = new FailoverProcessServerProperties()
                {
                    ContainerName = "cloud_1f3c15af-2256-4568-9e06-e1ef4f728f75",
                    SourceProcessServerId = Guid.Parse("AFA0EC54-1894-4E44-9CAB02DB8854B117"),
                    TargetProcessServerId = Guid.Parse("5D3ED340-85AE-C646-B338641E015DA405"),
                    VmsToMigrate =
{
"Vm1","Vm2"
},
                    UpdateType = "ServerLevel",
                },
            };
            ArmOperation<SiteRecoveryFabricResource> lro = await siteRecoveryFabric.ReassociateGatewayAsync(WaitUntil.Completed, content);
            SiteRecoveryFabricResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes the site.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesTheSite()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationFabrics_Delete.json
            // this example is just showing the usage of "ReplicationFabrics_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // invoke the operation
            await siteRecoveryFabric.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Renews certificate for the fabric.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RenewCertificate_RenewsCertificateForTheFabric()
        {
            // Generated from example definition: specification/recoveryservicessiterecovery/resource-manager/Microsoft.RecoveryServices/stable/2023-06-01/examples/ReplicationFabrics_RenewCertificate.json
            // this example is just showing the usage of "ReplicationFabrics_RenewCertificate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteRecoveryFabricResource created on azure
            // for more information of creating SiteRecoveryFabricResource, please refer to the document of SiteRecoveryFabricResource
            string subscriptionId = "c183865e-6077-46f2-a3b1-deb0f4f4650a";
            string resourceGroupName = "resourceGroupPS1";
            string resourceName = "vault1";
            string fabricName = "cloud1";
            ResourceIdentifier siteRecoveryFabricResourceId = SiteRecoveryFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, fabricName);
            SiteRecoveryFabricResource siteRecoveryFabric = client.GetSiteRecoveryFabricResource(siteRecoveryFabricResourceId);

            // invoke the operation
            RenewCertificateContent content = new RenewCertificateContent()
            {
                RenewCertificateType = "Cloud",
            };
            ArmOperation<SiteRecoveryFabricResource> lro = await siteRecoveryFabric.RenewCertificateAsync(WaitUntil.Completed, content);
            SiteRecoveryFabricResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SiteRecoveryFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
