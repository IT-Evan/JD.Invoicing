using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using JD.Invoicing.Authorization.Users;
using JD.Invoicing.Editions;

namespace JD.Invoicing.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
