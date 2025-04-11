//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class AzureKeyVaultResourceExtensions
    {
        public static ApplicationModel.IResourceBuilder<Azure.AzureKeyVaultResource> AddAzureKeyVault(this IDistributedApplicationBuilder builder, string name) { throw null; }

        public static ApplicationModel.IResourceBuilder<T> WithRoleAssignments<T>(this ApplicationModel.IResourceBuilder<T> builder, ApplicationModel.IResourceBuilder<Azure.AzureKeyVaultResource> target, params global::Azure.Provisioning.KeyVault.KeyVaultBuiltInRole[] roles)
            where T : ApplicationModel.IResource { throw null; }
    }
}

namespace Aspire.Hosting.Azure
{
    public partial class AzureKeyVaultResource : AzureProvisioningResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IResource, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences, IAzureKeyVaultResource, ApplicationModel.IAzureResource
    {
        public AzureKeyVaultResource(string name, System.Action<AzureResourceInfrastructure> configureInfrastructure) : base(default!, default!) { }

        System.Func<IAzureKeyVaultSecretReference, System.Threading.CancellationToken, System.Threading.Tasks.Task<string?>>? IAzureKeyVaultResource.SecretResolver { get { throw null; } set { } }

        BicepOutputReference IAzureKeyVaultResource.VaultUriOutputReference { get { throw null; } }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public BicepOutputReference NameOutputReference { get { throw null; } }

        public BicepOutputReference VaultUri { get { throw null; } }

        public override global::Azure.Provisioning.Primitives.ProvisionableResource AddAsExistingResource(AzureResourceInfrastructure infra) { throw null; }

        public IAzureKeyVaultSecretReference GetSecret(string secretName) { throw null; }
    }
}