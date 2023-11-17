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
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_FrontDoorSecretCollection
    {
        // Secrets_ListByProfile
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SecretsListByProfile()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Secrets_ListByProfile.json
            // this example is just showing the usage of "FrontDoorSecrets_ListByProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecretResource
            FrontDoorSecretCollection collection = profile.GetFrontDoorSecrets();

            // invoke the operation and iterate over the result
            await foreach (FrontDoorSecretResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorSecretData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Secrets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SecretsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Secrets_Get.json
            // this example is just showing the usage of "FrontDoorSecrets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecretResource
            FrontDoorSecretCollection collection = profile.GetFrontDoorSecrets();

            // invoke the operation
            string secretName = "secret1";
            FrontDoorSecretResource result = await collection.GetAsync(secretName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorSecretData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Secrets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SecretsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Secrets_Get.json
            // this example is just showing the usage of "FrontDoorSecrets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecretResource
            FrontDoorSecretCollection collection = profile.GetFrontDoorSecrets();

            // invoke the operation
            string secretName = "secret1";
            bool result = await collection.ExistsAsync(secretName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Secrets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SecretsGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Secrets_Get.json
            // this example is just showing the usage of "FrontDoorSecrets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecretResource
            FrontDoorSecretCollection collection = profile.GetFrontDoorSecrets();

            // invoke the operation
            string secretName = "secret1";
            NullableResponse<FrontDoorSecretResource> response = await collection.GetIfExistsAsync(secretName);
            FrontDoorSecretResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontDoorSecretData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Secrets_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SecretsCreate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Secrets_Create.json
            // this example is just showing the usage of "FrontDoorSecrets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProfileResource created on azure
            // for more information of creating ProfileResource, please refer to the document of ProfileResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            ResourceIdentifier profileResourceId = ProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            ProfileResource profile = client.GetProfileResource(profileResourceId);

            // get the collection of this FrontDoorSecretResource
            FrontDoorSecretCollection collection = profile.GetFrontDoorSecrets();

            // invoke the operation
            string secretName = "secret1";
            FrontDoorSecretData data = new FrontDoorSecretData()
            {
                Properties = new CustomerCertificateProperties(new WritableSubResource()
                {
                    Id = new ResourceIdentifier("/subscriptions/subid/resourcegroups/RG/providers/Microsoft.KeyVault/vault/kvName/secrets/certificatename"),
                })
                {
                    SecretVersion = "abcdef1234578900abcdef1234567890",
                    UseLatestVersion = false,
                },
            };
            ArmOperation<FrontDoorSecretResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, secretName, data);
            FrontDoorSecretResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorSecretData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
