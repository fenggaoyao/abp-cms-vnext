using Cms.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Docs;
using Volo.Blogging;

namespace Cms
{
    [DependsOn(
        typeof(CmsDomainModule),
        typeof(DocsApplicationModule),
        typeof(BloggingApplicationModule),
        typeof(AbpIdentityApplicationModule))]
    public class CmsApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<PermissionOptions>(options =>
            {
                options.DefinitionProviders.Add<CmsPermissionDefinitionProvider>();
            });

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<CmsApplicationAutoMapperProfile>();
            });
        }
    }
}
