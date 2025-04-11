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
    public static partial class AzurePostgresExtensions
    {
        public static ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> AddAzurePostgresFlexibleServer(this IDistributedApplicationBuilder builder, string name) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerDatabaseResource> AddDatabase(this ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> builder, string name, string? databaseName = null) { throw null; }

        [System.Obsolete("This method is obsolete and will be removed in a future version. Use AddAzurePostgresFlexibleServer instead to add an Azure PostgreSQL Flexible Server resource.")]
        public static ApplicationModel.IResourceBuilder<ApplicationModel.PostgresServerResource> AsAzurePostgresFlexibleServer(this ApplicationModel.IResourceBuilder<ApplicationModel.PostgresServerResource> builder) { throw null; }

        [System.Obsolete("This method is obsolete and will be removed in a future version. Use AddAzurePostgresFlexibleServer instead to add an Azure PostgreSQL Flexible Server resource.")]
        public static ApplicationModel.IResourceBuilder<ApplicationModel.PostgresServerResource> PublishAsAzurePostgresFlexibleServer(this ApplicationModel.IResourceBuilder<ApplicationModel.PostgresServerResource> builder) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> RunAsContainer(this ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> builder, System.Action<ApplicationModel.IResourceBuilder<ApplicationModel.PostgresServerResource>>? configureContainer = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> WithPasswordAuthentication(this ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> builder, ApplicationModel.IResourceBuilder<ApplicationModel.ParameterResource>? userName = null, ApplicationModel.IResourceBuilder<ApplicationModel.ParameterResource>? password = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> WithPasswordAuthentication(this ApplicationModel.IResourceBuilder<Azure.AzurePostgresFlexibleServerResource> builder, ApplicationModel.IResourceBuilder<Azure.IAzureKeyVaultResource> keyVaultBuilder, ApplicationModel.IResourceBuilder<ApplicationModel.ParameterResource>? userName = null, ApplicationModel.IResourceBuilder<ApplicationModel.ParameterResource>? password = null) { throw null; }
    }
}

namespace Aspire.Hosting.Azure
{
    public partial class AzurePostgresFlexibleServerDatabaseResource : ApplicationModel.Resource, ApplicationModel.IResourceWithParent<AzurePostgresFlexibleServerResource>, ApplicationModel.IResourceWithParent, ApplicationModel.IResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences
    {
        public AzurePostgresFlexibleServerDatabaseResource(string name, string databaseName, AzurePostgresFlexibleServerResource postgresParentResource) : base(default!) { }

        public override ApplicationModel.ResourceAnnotationCollection Annotations { get { throw null; } }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public string DatabaseName { get { throw null; } }

        public AzurePostgresFlexibleServerResource Parent { get { throw null; } }
    }

    public partial class AzurePostgresFlexibleServerResource : AzureProvisioningResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IResource, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences
    {
        public AzurePostgresFlexibleServerResource(string name, System.Action<AzureResourceInfrastructure> configureInfrastructure) : base(default!, default!) { }

        public override ApplicationModel.ResourceAnnotationCollection Annotations { get { throw null; } }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public System.Collections.Generic.IReadOnlyDictionary<string, string> Databases { get { throw null; } }

        [System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, "ConnectionStringSecretOutput")]
        public bool UsePasswordAuthentication { get { throw null; } }

        public override global::Azure.Provisioning.Primitives.ProvisionableResource AddAsExistingResource(AzureResourceInfrastructure infra) { throw null; }

        public override void AddRoleAssignments(IAddRoleAssignmentsContext roleAssignmentContext) { }
    }

    [System.Obsolete("This class is obsolete and will be removed in a future version. Use AddAzurePostgresFlexibleServer instead to add an Azure Postgres Flexible Server resource.")]
    public partial class AzurePostgresResource : AzureProvisioningResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IResource, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences
    {
        public AzurePostgresResource(ApplicationModel.PostgresServerResource innerResource, System.Action<AzureResourceInfrastructure> configureInfrastructure) : base(default!, default!) { }

        public override ApplicationModel.ResourceAnnotationCollection Annotations { get { throw null; } }

        public BicepSecretOutputReference ConnectionString { get { throw null; } }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public override string Name { get { throw null; } }
    }
}